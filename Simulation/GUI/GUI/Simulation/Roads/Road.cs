using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GUI.Mathematical_Tools;
using GUI.Simulation.Logging;

using GUI.Simulation;
using GUI.Simulation.Geometry;
using GUI.Simulation.Roads.Lanes;

namespace GUI.Simulation.Roads
{
    public class Road
    {
        public LogModule log;

        public Average AverageWaitTime = new Average();

        public string RoadID { get; private set; }
        public Rectangle2D RoadBound;

        public char SignalState = 'R'; // R = red, Y = yellow, G = green

        private bool isOpen => SignalState == 'G';

        public Lane LeftLane, RightLane;

        public Road(string roadID, Rectangle2D roadBound, Rectangle2D ExitLeftLaneBound, Rectangle2D ExitRightLaneBound)
        {
            RoadID = roadID;
            RoadBound = roadBound;

            LeftLane = new Lane(roadID + "\\LEFT", new Rectangle2D(RoadBound.Length, RoadBound.Breadth / 2, Point2D.MidPoint(RoadBound.OD, RoadBound.Midpoint), RoadBound.Inclination), new Point2D(ExitLeftLaneBound.OC));
            RightLane = new Lane(roadID + "\\RIGHT", new Rectangle2D(RoadBound.Length, RoadBound.Breadth / 2, Point2D.MidPoint(new Point2D(RoadBound.OB).Move(1, RoadBound.Inclination + Angle.A90), RoadBound.Midpoint), RoadBound.Inclination), new Point2D(ExitRightLaneBound.OC));

            log = new LogModule(roadID);
            log.Add("");
        }

        public ushort Refresh()
        {
            int x = (ushort)(LeftLane.Refresh(isOpen) + RightLane.Refresh(isOpen));

            AverageWaitTime += LeftLane.AverageWaitTime + RightLane.AverageWaitTime;

            LeftLane.AverageWaitTime.Reset();
            RightLane.AverageWaitTime.Reset();

            log.Add("avgwt= " + AverageWaitTime.AverageValue + "s");

            return (ushort)x;
        }

        public ushort NofVehicles => (ushort)(LeftLane.Vehicles.Count + RightLane.Vehicles.Count);

        public override string ToString() => RoadID + " (" + NofVehicles + ")";

    }
}
