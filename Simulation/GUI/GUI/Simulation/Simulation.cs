using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GUI.Mathematical_Tools;
using GUI.Simulation.Logging;
using GUI.Simulation.Roads;
using GUI.Simulation.Geometry;


namespace GUI.Simulation
{
    public class Simulation
    {

        public ulong Uptime = 0;

        public LogModule log;

        public Average AverageWaitTime = new Average();

        public static ulong _nof_vehicles_ = 0;
        public static ulong GetVehicleID => ++_nof_vehicles_;

        public string JunctionID = "";

        public static int RefreshRate => Properties.Settings.Default.Simulation_ComputeAccuraccy;

        public List<Road> Roads = new List<Road>();

        public SerialPort MySerial = new SerialPort();

        public Simulation(string junctionID, SerialPort serialport)
        {
            Roads.AddRange(new Road[] {
                new Road(junctionID + "\\NORTH", new Rectangle2D(Terrains.SampleJunction.WEST.Entry.RoadBound), new Rectangle2D(Terrains.SampleJunction.NORTH.Exit.LaneL), new Rectangle2D(Terrains.SampleJunction.SOUTH.Exit.LaneR)),
                new Road(junctionID + "\\EAST", new Rectangle2D(Terrains.SampleJunction.NORTH.Entry.RoadBound), new Rectangle2D(Terrains.SampleJunction.EAST.Exit.LaneL), new Rectangle2D(Terrains.SampleJunction.WEST.Exit.LaneR)),
                new Road(junctionID + "\\SOUTH", new Rectangle2D(Terrains.SampleJunction.EAST.Entry.RoadBound), new Rectangle2D(Terrains.SampleJunction.SOUTH.Exit.LaneL), new Rectangle2D(Terrains.SampleJunction.NORTH.Exit.LaneR)),
                new Road(junctionID + "\\WEST", new Rectangle2D(Terrains.SampleJunction.SOUTH.Entry.RoadBound), new Rectangle2D(Terrains.SampleJunction.WEST.Exit.LaneL), new Rectangle2D(Terrains.SampleJunction.EAST.Exit.LaneR))
            });

            JunctionID = junctionID;

            MySerial = serialport;

            log = new LogModule(junctionID);
        }

        public void FlushLog()
        {
            log.FlushBuffer();
            //Junction.log.FlushBuffer();
            foreach(Road road in Roads)
            {
                road.LeftLane.errorLog.FlushBuffer();
                road.RightLane.errorLog.FlushBuffer();
                road.log.FlushBuffer();
            }
        }

        private ushort counter_0 = 0;

        public void Refresh()
        {
            ++counter_0;

            if (counter_0 == (1000 / Properties.Settings.Default.Simulation_ComputeInterval))
            {
                counter_0 = 0;

                for (int i = 0; i < Roads.Count; ++i)
                    MySerial.Write("#VC" + i.ToString() + "<" + Roads.ElementAt(i).Refresh().ToString() + ">");

                MySerial.Write(";");
            }
            else
            {
                Parallel.For(0, Roads.Count, i =>
                {
                    Roads.ElementAt(i).Refresh();
                });
            }

            UpdateSerialRead();

            for (int i = 0; i < 4; ++i)
            {
                AverageWaitTime += Roads.ElementAt(i).AverageWaitTime;
                Roads.ElementAt(i).AverageWaitTime.Reset();
                log.Add("avgwt= " + AverageWaitTime.AverageValue + "s");
            }
        }

        private char buff = 'n';

        private void UpdateSerialRead()
        {
            while (MySerial.BytesToRead > 0)
            {
                buff = (char)MySerial.ReadChar();
                Console.Write(buff);

                if (buff == '$')
                {
                    for (int i = 0; i < Roads.Count; ++i)
                        Roads.ElementAt(i).SignalState = (char)MySerial.ReadChar();

                    ++Uptime;
                }
            }
        }
    }

}
