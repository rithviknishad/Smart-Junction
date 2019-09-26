using System;
using System.Collections.Generic;

using GUI.Core.Support.Analytics.Average;
using GUI.Core.Support.Priorities;
using GUI.Core.Junction.Signals;
using GUI.Core.Junction.Vehicles;

namespace GUI.Core.Junction.Roads
{

    public partial class Road : IEquatable<Road>
    {
        public string RoadID { get; private set; }

        internal Settings Settings = new Settings();
        internal Statistics Statistics = new Statistics();
        internal Priority Priority = new Priority();
        public Signal Signal { get; private set; } = new Signal(0);

        private bool IsOpen { get; set; } = false;
        public bool HasGreenLockEnabled { get; private set; } = false;
        public bool ExtraTimeGiven { get; set; } = false;

        public Road(string roadID, byte signalID)
        {
            RoadID = roadID;
            Signal = new Signal(signalID);
        }

        public void RequestGreenTunneling()
        {
            if (Settings.GreenTunneling.Enabled)
            {
                Settings.GreenTunneling.IsPending = true;
            }
        }

        public ushort CurrentActivityDuration = 0;
        public ushort CurrentWaitingTime = 0;
        public ushort nof_Vehicles { get; set; } = 0;

        public List<EmergencyVehicle> Emergency_VehicleList = new List<EmergencyVehicle>();

        public ushort PLF() // Priority Level Factor
        {
            return Priority.Level;
        }

        public void Emergency_AddVehicle(string registrationNumber, uint distance = 40)
        {
            Emergency_VehicleList.Add(new EmergencyVehicle(registrationNumber, distance));
            Refresh_Priority();
            // emergency variance priority
        }

        public void Emergency_RemoveVehicle(EmergencyVehicle emergencyVehicle)
        {
            Emergency_VehicleList.Remove(emergencyVehicle);
        }
        
        public bool NeedsExtraTime
        {
            get
            {
                if (IsOpen && Settings.ExtraTime.Enabled && nof_Vehicles != 0 && nof_Vehicles <= Settings.ExtraTime.MaxVehicleThreshold && !ExtraTimeGiven)
                    return true;
                else
                    return false;
            }
        }

        public void Close()
        {
            if (IsOpen)
            {
                Statistics.AVG_TimeOpen.Add(CurrentActivityDuration);
                CurrentActivityDuration = 0;
                ExtraTimeGiven = false;
            }

            Signal.State = SignalStates.Red;
            IsOpen = false;
        }

        public bool RoadIsClosed()
        {
            return (Signal.State == SignalStates.Red ? true : false);
        }

        public bool RoadIsOpen()
        {
            return !RoadIsClosed();
        }

        public void SwitchOff()
        {
            if (IsOpen)
            {
                Close();
                Signal.State = SignalStates.Off;
            }
        }

        private void SwitchOn()
        {
            Close();
            Signal.State = SignalStates.Red;
        }

        public void SwitchOn(bool ResetStatistics, bool ResetSettings, bool ResetEmergencies)
        {
            SwitchOn();

            if (ResetEmergencies)
                Emergency_VehicleList.Clear();

            if (ResetStatistics)
                Statistics = new Statistics();

            if (ResetSettings)
            {
                Priority = new Priority();
                Settings = new Settings();
            }
        }

        public void SwitchOn(bool reset)
        {
            SwitchOn(reset, reset, reset);
        }

        public void Open(bool isOpeningForEmergency)
        {
            if (!IsOpen)
            {
                ExtraTimeGiven = false;

                Statistics.AVG_TimeWait.Add(CurrentWaitingTime);
                CurrentWaitingTime = 0;

                CurrentActivityDuration = 0;
                ++Statistics.NOFT_Opened;
            }

            IsOpen = true;

            Signal.State = (isOpeningForEmergency ? SignalStates.Emergency : SignalStates.Green);

            if (isOpeningForEmergency)
                ++Statistics.NOF_EmergenciesHandled;
        }

        public ushort HighestPriorityValueInEmergency()
        {
            ushort x = 0;
            foreach (EmergencyVehicle cV in Emergency_VehicleList)
            {
                if (((ushort)cV.PriorityLevel) > x)
                    x = (ushort)cV.PriorityLevel;
            }
            return x;
        }

        public void Refresh_Priority()
        {
            if (HasGreenLockEnabled)
                Priority.Level = (ushort)PriorityLevels.GreenLock;
            else if (Emergency_VehicleList.Count > 0)
                Priority.Level = HighestPriorityValueInEmergency();
            else if (nof_Vehicles > 0 && !Settings.FacingDownTime)
                Priority.Level = (ushort)(Priority.DefaultPreferenceIsHigh ? PriorityLevels.High : PriorityLevels.Normal);
            else
                Priority.Level = 0;
        }

        public void EmergencyCoolDown()
        {
            Close();
            
        }

        public byte GiveExtraTime()
        {
            if (NeedsExtraTime)
            {
                ExtraTimeGiven = true;
                return Settings.ExtraTime.MaxExtraTime;
            }
            else
            {
                Close();
                return 0;
            }
        }

        public bool EarlyExit()
        {
            if (Settings.EarlyExit.Enabled && nof_Vehicles == 0 && Priority.Level < ((ushort)PriorityLevels.High_MAX + 1))
            {
                Close();
                ++Statistics.NOFT_ClosedBeforeTimeout;
                return true;
            }
            else
                return false;
        }

        public void Refresh()
        {

            Refresh_Priority();

            ++CurrentActivityDuration;

            if (RoadIsClosed() && nof_Vehicles > 0)
                ++CurrentWaitingTime;
        }

        public void SetRoadSettingsToSmart(bool value)
        {
            Settings.ExtraTime.Enabled = value;
            Settings.EarlyExit.Enabled = value;
            Settings.GreenTunneling.Enabled = value;
        }

        public void WriteDowntime(bool downtime)
        {
            Settings.FacingDownTime = downtime;
        }

        public override string ToString()
        {
            return RoadID;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Road);
        }

        public bool Equals(Road other)
        {
            return other != null && RoadID == other.RoadID;
        }

        public override int GetHashCode()
        {
            return -226575706 + EqualityComparer<string>.Default.GetHashCode(RoadID);
        }

        public static bool operator ==(Road road1, Road road2)
        {
            return road1.RoadID == road2.RoadID;
        }

        public static bool operator !=(Road road1, Road road2)
        {
            return !(road1 == road2);
        }
    }

    public class Statistics
    {

        public AverageU16_32 AVG_NOF_VEHICLES;
        public AverageFLOAT32 AVG_TimeWait;
        public AverageFLOAT32 AVG_TimeOpen;
        public AverageFLOAT32 AVG_TimeToClearAVehicle;

        public ushort NOF_EmergenciesHandled = 0;

        public uint NOF_VehiclesCleared = 0;
        public uint NOFT_ClosedBeforeTimeout = 0;
        public uint NOFT_Opened;

        public Statistics()
        {
            AVG_NOF_VEHICLES = new AverageU16_32();
            AVG_TimeWait = new AverageFLOAT32();
            AVG_TimeOpen = new AverageFLOAT32();
            AVG_TimeToClearAVehicle = new AverageFLOAT32();
        }

        public void ResetStatistics()
        {

            AVG_NOF_VEHICLES.Reset();
            AVG_TimeWait.Reset();
            AVG_TimeOpen.Reset();
            AVG_TimeToClearAVehicle.Reset();

            NOF_EmergenciesHandled = 0;
            NOFT_ClosedBeforeTimeout = 0;
            NOFT_Opened = 0;

        }

        public bool RequiresStatisticsOffloading()
        {
            if ( /// additional conditions to be seperated by || (OR)
                false
                || NOF_EmergenciesHandled > 10000
                || NOF_VehiclesCleared > 10000
                || NOFT_ClosedBeforeTimeout > 10000
                || NOFT_Opened > 10000
                )
                return true;
            else
                return false;
        }

    }

    public class Settings
    {
        public byte MaxOpenTime { get; set; } = 30;
        public bool FacingDownTime { get; set; } = false;

        public class _EarlyExit
        {
            private bool ENABLED = true;
            public bool Enabled
            {
                get
                {
                    return ENABLED;
                }
                set
                {
                    ENABLED = value;
                }
            }
        }

        public class _GreenTunneling
        {
            private bool ENABLED = true;
            public bool Enabled
            {
                get
                {
                    return ENABLED;
                }
                set
                {
                    ENABLED = value;
                }
            }

            private bool ISPENDING = false;
            public bool IsPending
            {
                get
                {
                    return ISPENDING;
                }
                set
                {
                    ISPENDING = value;
                }
            }
        }

        public class _ExtraTime
        {
            private bool ENABLED = true;
            public bool Enabled
            {
                get
                {
                    return ENABLED;
                }
                set
                {
                    ENABLED = value;
                }
            }

            private byte MAXVEHICLETHRESHOLD = 2;
            public byte MaxVehicleThreshold
            {
                get
                {
                    return MAXVEHICLETHRESHOLD;
                }
                set
                {
                    MAXVEHICLETHRESHOLD = value;
                }
            }

            private byte MAXEXTRATIME = 5;
            public byte MaxExtraTime
            {
                get
                {
                    return MAXEXTRATIME;
                }
                set
                {
                    MAXEXTRATIME = value;
                }
            }
        }

        public _EarlyExit EarlyExit;
        public _GreenTunneling GreenTunneling;
        public _ExtraTime ExtraTime;

        public Settings()
        {
            EarlyExit = new _EarlyExit();
            GreenTunneling = new _GreenTunneling();
            ExtraTime = new _ExtraTime();
        }
    }

}