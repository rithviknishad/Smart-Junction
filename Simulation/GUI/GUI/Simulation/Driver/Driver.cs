namespace GUI.Simulation.Drivers
{

    public class Driver
    {

        private double TOPSPEED = 22;
        private double ACCELERATION = 2;
        private double RETARDATION = 1;

        public double TopSpeed(double framerate) => (TOPSPEED / framerate);
        public double Acceleration(double framerate) => (ACCELERATION / framerate);
        public double Retardation(double framerate) => (RETARDATION / framerate);

        /// <summary>
        /// Configure driver
        /// </summary>
        /// <param name="topSpeed">Top Speed of Driver [m/s]</param>
        /// <param name="acceleration">Acceleration of Driver [m/ss]</param>
        /// <param name="retardation">Retardation of Driver [m/ss]. Leave blank or as 0 to use same value of acceleration</param>
        public Driver(double topSpeed, double acceleration, double retardation = 0)
        {
            TOPSPEED = topSpeed;
            ACCELERATION = acceleration;
            RETARDATION = (retardation != 0 ? retardation : (acceleration * 1.5));
        }
    }
}
