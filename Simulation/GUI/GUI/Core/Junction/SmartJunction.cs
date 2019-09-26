using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GUI.Core.Junction.Roads;
using GUI.Core.Support.Priorities;

using GUI.Simulation.Logging;

namespace GUI.Core.Junction
{
    public enum JunctionModes { Off = 0, Smart, Loop, RemoteControl }

    public class Junction
    {

        public LogModule log;

        public string JunctionID { get; private set; } = "#NULL";
        public ulong JunctionUptime { get; private set; } = 0;

        private JunctionModes __JUNCTIONMODE = JunctionModes.Smart;
        public JunctionModes JunctionMode
        {
            get
            {
                return __JUNCTIONMODE;
            }
            set
            {
                // list of other commands to be made before changing...
                switch (value)
                {
                    case JunctionModes.Off:
                        counter = 0xFF;
                        ResetCycle();
                        Parallel.ForEach(RoadList, (road) => road.SwitchOff());
                        break;

                    case JunctionModes.Smart:
                        OverrideCtrlOnEmergency = true;
                        Parallel.ForEach(RoadList, (r) => r.SetRoadSettingsToSmart(true));
                        break;

                    case JunctionModes.Loop:
                        OverrideCtrlOnEmergency = true;
                        Parallel.ForEach(RoadList, (r) => r.SetRoadSettingsToSmart(false));
                        break;

                    case JunctionModes.RemoteControl:
                        counter = 0xFE;
                        OverrideCtrlOnEmergency = false;
                        break;
                }
                // to add stats handler code...
                __JUNCTIONMODE = value;
            }
        }

        public bool OverrideCtrlOnEmergency { get; set; } = true;
        public byte MaxOpenTime { get; private set; } = 30;
        public byte RoadTurnOverDelay { get; private set; } = 3;

        public List<Road> RoadList = new List<Road>();

        //--
        public Junction(string jncID, IEnumerable<Road> roadList, JunctionModes junctionMode, bool overrideCtrlOnEmergency, byte maxOpenTime, byte roadTurnOverDelay)
        {
            JunctionID = jncID;

            RoadList.Clear(); // create a reset all function
            CREM.Clear();

            foreach (Road r in roadList)
                RoadList.Add(r);

            JunctionMode = junctionMode;
            OverrideCtrlOnEmergency = overrideCtrlOnEmergency;
            MaxOpenTime = maxOpenTime;
            RoadTurnOverDelay = roadTurnOverDelay;

            ResetCycle();
            TimeLeftForNextActivity = 1;



            log = new LogModule("CORE\\" + jncID);

            log.Add(new string[]
            {
                "<INIT_CONFIG>",
                "\tjnc_id = " + jncID,
                "\tjncMode = " + junctionMode,
                "\toverride_ctrl_on_emergency = " + overrideCtrlOnEmergency,
                "\tmax_open_time = " + maxOpenTime,
                "\troad_turn_over_delay = " + roadTurnOverDelay,
                "</INIT_CONFIG>"
            });

            log.FlushBuffer();



        }

        public byte counter { get; private set; } = 0;

        /*
		    Current Execution Level Value Table:

		    0				Begin of new cycle
		    [1, NOFROADS]	Execution Level of each track
		    NOFROADS + 2	Emergency being executed
		    NOFROADS + 3	Green lock

		    > NOFROADS + 3	Junction Halut Error Codes

            0xFE            Junction Mode is set to REMOTECONTROL!
		    0xFF	        Junction Mode is set to OFF!
	    */

        public List<string> CREM = new List<string>(); // CREM = Current Road Execution Memory

        public const string NoRoad = "NULL";
        public string CurrentActiveRoad
        {
            get
            {
                foreach (Road road in RoadList)
                    if (road.RoadIsOpen())
                        return road.RoadID;
                return NoRoad;
            }
        }

        public ushort TimeLeftForNextActivity { get; private set; } = 0;

        private void ResetCycle()
        {
            CREM.Clear();
            counter = 0;
            TimeLeftForNextActivity = 0;
            // reset other functional variables
        }

        public void TurnOffJunction()
        {
            JunctionMode = JunctionModes.Off;
            //stats handler code
        }

        public void TurnOnJunction(JunctionModes junctionMode, bool reset)
        {
            if (JunctionMode == JunctionModes.Off)
            {
                JunctionMode = junctionMode;
                foreach (Road road in RoadList)
                    road.SwitchOn(reset);
            }
        }

        // push max commands to road class refresh() for parallel computing...

        public string RoadHavingHighestEmergency()
        {
            string toReturn = NoRoad;

            byte level = 0;

            foreach (Road road in RoadList.Where(road => (road.Priority.Level >= (ushort)PriorityLevels.Emergency_MIN)))
            {
                if (level < road.HighestPriorityValueInEmergency())
                {
                    level = (byte)road.HighestPriorityValueInEmergency();
                    toReturn = road.RoadID;
                }
            }

            return toReturn;
        }

        public void OpenRoad(string roadID, bool isEmergency = false)
        {
            log.Add("CHANGES: OPEN_ROAD (roadID = " + roadID + " isEmergency = " + isEmergency);
            Parallel.ForEach(RoadList, (r) =>
            {
                if (r.RoadID == roadID)
                {
                    r.Open(isEmergency);
                    TimeLeftForNextActivity = r.Settings.MaxOpenTime;
                }
                else
                    r.Close();
            });
        }
        public void OpenRoadForEmergency(string roadID)
        {
            counter = (byte)(RoadList.Count + 2);
            OpenRoad(roadID, true);
            // raise emergency flags and push to server
        }

        string __temps_ActiveRoad = "";
        public void Refresh()
        {
            ++JunctionUptime; /// Increments frame counter, as algorithm is still running
                              /// xxxxxxxxxxxxxxxx --- WRITE ALL OTHER COMMANDS BELOW THIS --- xxxxxxxxxxxxxxxx

            log.Add("<session = " + JunctionUptime + ">");


            if (JunctionMode == JunctionModes.Off)
            {
                log.Add("\tJunctionModes.Off -> Current session terminated");
                log.Add("</session>");

                return;
            }


            if (TimeLeftForNextActivity > 0)
                --TimeLeftForNextActivity;

            log.Add("\t\"TimeLeftForNextActivity\" = " + TimeLeftForNextActivity);

            // code to handle statistics and overflow prevention and server management
            // also create new server class for acting as a buffer memory before server.push()

            foreach (Road road in RoadList)
            {
                road.Refresh();
                log.Add(new string[]
                {
                    "\t<road = " + road.RoadID + ">",
                    "\t\t\"priority\" = " + road.Priority.Level,
                    "\t\t\"nof_vehicles\" = " + road.nof_Vehicles,
                    "\t\t\"singalstate\" = " + road.Signal.State,
                    "\t</road>"
                });
            }

            if (OverrideCtrlOnEmergency && RoadHavingHighestEmergency() != NoRoad)
            {
                log.Add("\tinfo: emergency_found");
                OpenRoadForEmergency(RoadHavingHighestEmergency());
                return;
            }

            __temps_ActiveRoad = CurrentActiveRoad;
            if (__temps_ActiveRoad != NoRoad)
            {
                foreach (Road road in RoadList.Where(road => road.RoadIsOpen()))
                {
                    if (TimeLeftForNextActivity == 0)
                        TimeLeftForNextActivity += road.GiveExtraTime();
                    else if (road.EarlyExit())
                        TimeLeftForNextActivity = 0;
                }
            }
            if (CurrentActiveRoad != __temps_ActiveRoad)
                TimeLeftForNextActivity = RoadTurnOverDelay;

            if (TimeLeftForNextActivity == 0)
            {
                ArrangeCycle();
                UpdateChanges();
            }

            log.Add("</session>");

        }

        private bool RoadIsAlreadyCleared(string roadID)
        {
            return CREM.Contains(roadID);
        }

        private void AssignNext()
        {
            for (byte iPriority = (byte)PriorityLevels.High_MAX; iPriority >= (byte)PriorityLevels.Normal_MIN; --iPriority)
            {
                //Parallel.ForEach(RoadList, (road) =>
                //{
                //    if (road.Priority.Level == iPriority && !RoadIsAlreadyCleared(road.RoadID))
                //    {
                //        CREM.Add(road.RoadID);
                //        return;
                //    }
                //});

                foreach (Road road in RoadList)
                {
                    if (road.PLF() == iPriority && !RoadIsAlreadyCleared(road.RoadID))
                    {
                        CREM.Add(road.RoadID);
                        return;
                    }
                }
            }
        }

        private void ArrangeCycle()
        {

            if (counter == RoadList.Count)
                ResetCycle();

            switch (JunctionMode)
            {
                case JunctionModes.Smart:

                    if (counter < RoadList.Count)
                        AssignNext();
                    break;

                case JunctionModes.Loop:

                    for (byte i = 0; i < RoadList.Count; ++i)
                        CREM.Add(RoadList.ToArray()[i].RoadID);

                    break;

            }
        }

        private void UpdateChanges()
        {
            if (JunctionMode == JunctionModes.RemoteControl)
                return;

            if (counter < RoadList.Count && (CREM.Count > counter))
                OpenRoad(CREM.ToArray()[counter++]);

            else if (counter < RoadList.Count + 2)
                ResetCycle();
        }

        public override string ToString()
        {
            return JunctionID;
        }

        // parallel for each make sure each task finishes and then only continues
        // junction advanced DeepAnalysis Factors (like TrafficPeaks and other reporting...)
        // avg class update: add avg of last 'x' vlaues (convert VALUE to list, and auto delete upon adding
    }
}