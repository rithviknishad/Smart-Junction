using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GUI.Mathematical_Tools;

using GUI.Simulation.Terrains;
using GUI.Simulation.Geometry;
using GUI.Simulation.Drivers;


namespace GUI.Simulation.Vehicles
{


    public class Vehicle
    {
        public bool IsFree { get; private set; } = false;

        public double DistanceToJunction => Point2D.DistanceBetween(SampleJunction.Junction_BOX.Midpoint, Position);
        public double DistanceToParking => Point2D.DistanceBetween(ParkingBound.Midpoint, Position);

        public ulong VehicleID { get; private set; } = 0;

        public VehicleSpecs VehicleSpecs { get; private set; } = null;

        public Rectangle2D CurrentBound { get; private set; } = null;
        public Point2D Position => CurrentBound?.Midpoint;
        public Angle Heading => CurrentBound?.Inclination;

        public double Speed { get; private set; } = 0;
        public Angle SteeringWheelAngle { get; private set; } = new Angle(0, Angle.Unit.Degrees); // not used

        public Driver Driver = null;

        public Rectangle2D MyAssosciatedLane { get; private set; }

        public Rectangle2D ParkingBound { get; private set; } = null;
        public Point2D ParkingPosition => ParkingBound?.Midpoint;

        public Point2D ExitSnapPoint { get; private set; } = null;

        public double DurationAlive { get; private set; } = 0;
        public double DurationWait { get; private set; } = 0;

        public double AvailableTopSpeed => Compare.LeastOf(VehicleSpecs.TopSpeed(Simulation.RefreshRate), Driver.TopSpeed(Simulation.RefreshRate));
        public double AvailableAcceleration => Compare.LeastOf(VehicleSpecs.Acceleration(Simulation.RefreshRate), Driver.Acceleration(Simulation.RefreshRate));
        public double AvailableRetardation => Compare.LeastOf(VehicleSpecs.Retardation(Simulation.RefreshRate), Driver.Retardation(Simulation.RefreshRate));

        // add standard acceleration function (+delV and -delV in one function)

        /// <summary>
        /// Accelerates the vehicle speed and returns the change occured in speed
        /// </summary>
        /// <returns>double</returns>
        private double Accelerate(double rate) => -(Speed - (Speed = (Speed + rate) < AvailableTopSpeed ? (Speed + rate) : AvailableTopSpeed));

        /// <summary>
        /// Deccelerates the vehicle speed and returns the change occurred in speed
        /// </summary>
        /// <param name="rate">negatie delta v, value passed must be positive for intended application</param>
        /// <returns>double</returns>
        private double Retard(double rate) => -(Speed - (Speed = (Speed - rate) > 0 ? (Speed - rate) : 0));


        public Vehicle(Driver driver, VehicleSpecs vehicleSpecs, Rectangle2D spawnBound, Rectangle2D parkingPosition, Rectangle2D AssosciatedLane, Point2D exitSnapPoint)
        {
            Driver = driver;
            VehicleSpecs = vehicleSpecs;

            VehicleID = Simulation.GetVehicleID;
            CurrentBound = new Rectangle2D(spawnBound);
            ParkingBound = new Rectangle2D(parkingPosition);
            
            MyAssosciatedLane = new Rectangle2D(AssosciatedLane);
            ExitSnapPoint = new Point2D(exitSnapPoint);

            Speed = 0;
            IsFree = false;
            DurationAlive = 0;
            DurationWait = 0;
        }

        private Rectangle2D UpdateBounds() => CurrentBound = (Speed != 0) ? CurrentBound.Move(Speed, Heading).Rotate(SteeringWheelAngle, Position) : CurrentBound;

        public Point2D BrakeVector => new Point2D(Position).Move(Math.Abs(-Math.Pow(Speed, 2) / (2 * AvailableRetardation)), Heading);

        private List<Rectangle2D> SurroundingVehicleBounds { get; set; } = new List<Rectangle2D>();

        public bool IsGoingToCrash()
        {

            foreach (Rectangle2D vehicleBound in SurroundingVehicleBounds)
            {
                if (vehicleBound.Midpoint != CurrentBound.Midpoint)
                {
                    if (vehicleBound.PointLiesInside(BrakeVector) || vehicleBound.PointLiesInside(new Point2D(BrakeVector).Move(5, Heading)))
                        return true;
                }
            }

            return false;
        }



        public void Refresh(bool IsOpen, IEnumerable<Rectangle2D> surroundSense)
        {
            SurroundingVehicleBounds = new List<Rectangle2D>(surroundSense);

            if (MyAssosciatedLane.PointLiesInside(CurrentBound.Midpoint))
            {
                if (!IsGoingToCrash())
                {
                    if (!IsOpen)
                    {
                        if (ParkingBound.PointLiesInside(BrakeVector))
                        {
                            Retard(Math.Abs(Math.Pow(Speed, 2) / (2 * Point2D.DistanceBetween(Position, ParkingBound.Midpoint))));
                            if (Speed < 0.0001)
                            {
                                Speed = 0;
                            }
                        }
                        else
                        {
                            Accelerate(AvailableAcceleration);
                        }
                    }
                    else
                    {
                        Accelerate(AvailableAcceleration);
                    }
                }
                else
                {
                    Retard(AvailableRetardation);
                }
            }
            else if (SampleJunction.Junction_BOX.PointLiesInside(Position))
            {
                //SteeringWheelAngle = new Angle(Line2D.AngleBetween(new LineSegment2D(CurrentBound.Midpoint, ExitSnapPoint).Line, CurrentBound.MiddleLength.Line) / 2);
            }
            else if (DistanceToJunction > 50)
            {
                IsFree = true;
            }
            else
            {
                SteeringWheelAngle = new Angle(0, Angle.Unit.Revolutions);

                if (!IsGoingToCrash())
                {
                    Accelerate(AvailableAcceleration);
                }
                else
                {
                    Retard(AvailableRetardation);
                }
            }

            DurationAlive += 1 / (double)Simulation.RefreshRate;

            if (Speed == 0)
            {
                DurationWait += 1 / (double)Simulation.RefreshRate;
            }

            CurrentBound = new Rectangle2D(UpdateBounds());

        }

        public override string ToString() => VehicleID + " > " + CurrentBound + " Position: " + Position + " Heading: " + Heading;

    }
}
