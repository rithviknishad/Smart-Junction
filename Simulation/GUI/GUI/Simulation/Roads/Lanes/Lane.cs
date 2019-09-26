using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GUI.Simulation.Logging;
using GUI.Mathematical_Tools;
using GUI.Simulation;
using GUI.Simulation.Geometry;
using GUI.Simulation.Vehicles;
using GUI.Simulation.Drivers;

namespace GUI.Simulation.Roads.Lanes
{
    public class Lane
    {

        public LogModule errorLog;

        public Average AverageWaitTime = new Average();


        public string LaneID { get; private set; }

        public Rectangle2D LaneBound { get; private set; }
        public Point2D TurnLaneExitPoint { get; private set; }

        public Rectangle2D SpawnBound, StopBound;
        public Rectangle2D VisibleBound;


        public Lane(string laneID, Rectangle2D laneBound, Point2D turnLaneExitPoint)
        {
            LaneID = laneID;
            LaneBound = new Rectangle2D(laneBound);
            TurnLaneExitPoint = new Point2D(turnLaneExitPoint);

            SpawnBound = new Rectangle2D(4, 1.9, new Point2D(LaneBound.OA).Move(-200, LaneBound.Inclination), LaneBound.Inclination);
            StopBound = new Rectangle2D(4, 1.9, new Point2D(LaneBound.OA).Move(-10, LaneBound.Inclination), LaneBound.Inclination);

            VisibleBound = new Rectangle2D(100, LaneBound.Breadth, new Point2D(new Point2D(LaneBound.OA).Move(50, LaneBound.Inclination + Angle.A180)), LaneBound.Inclination);
            errorLog = new LogModule(laneID + "_ERRORS");
        }

        public List<Vehicle> Vehicles = new List<Vehicle>();

        /// <summary>
        /// checks whether its free to spawn
        /// </summary>
        /// <returns></returns>
        public bool IsFreeToSpawn()
        {
            Point2D spawnEdgePt = new Point2D(SpawnBound.AB.Midpoint);
            Point2D spawnEdgePtMx = new Point2D(spawnEdgePt).Move(2, LaneBound.Inclination);

            foreach(Vehicle vehicle in Vehicles)
            {
                if (vehicle.CurrentBound.PointLiesInside(spawnEdgePt) || vehicle.CurrentBound.PointLiesInside(spawnEdgePtMx))
                {
                    return false;
                }
            }

            return true;
        }

        private Point2D RandomDirectionLanePoint() => (Tools.RandomNumber(2) == 0) ? TurnLaneExitPoint : new Point2D(LaneBound.Midpoint).Move(100, LaneBound.Inclination);

        public ushort Refresh(bool isOpen)
        {
            ushort visibleCount = 0;

            foreach (Vehicle vehicle in Vehicles)
            {
                List<Rectangle2D> surround = new List<Rectangle2D>();

                foreach (Vehicle veh in Vehicles)
                {
                    if (veh.Position != vehicle.Position)
                    {
                        surround.Add(veh.CurrentBound);
                    }
                }

                vehicle.Refresh(isOpen, surround);

                if (LaneBound.PointLiesInside(vehicle.Position))
                    ++visibleCount;
            }

            for (int i = Vehicles.Count - 1; i >=0; --i)
            {
                if (Vehicles.ToArray()[i].IsFree)
                {
                    AverageWaitTime.Add(Vehicles.ToArray()[i].DurationWait);
                    Vehicles.RemoveAt(i);
                }
            }
            return visibleCount;
        }


        public void AddVehicleManual(Driver driver, VehicleSpecs vehicleSpecs)
        {
            if (IsFreeToSpawn())
            {
                Vehicles.Add(new Vehicle(driver, vehicleSpecs, SpawnBound, StopBound, new Rectangle2D(LaneBound), new Point2D(RandomDirectionLanePoint())));
            }
            else
            {
                errorLog.Add("VEHICLE SPAWN FAILED [EntryPointFullException]");
            }
        }

    }
}
