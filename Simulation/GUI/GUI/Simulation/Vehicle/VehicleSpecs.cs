namespace GUI.Simulation.Vehicles
{
    public class VehicleSpecs
    {
        
        private byte TOPSPEED = 10;
        private byte ACCELERATION = 3;
        private byte RETARDATION = 3;
        public string ModelName { get; private set; } = "";

        /// <summary>
        /// returns top speed in metres per frame
        /// </summary>
        /// <param name="framerate">framerate in fps</param>
        /// <returns>double</returns>
        public double TopSpeed(double framerate) => ((double)TOPSPEED / framerate);

        /// <summary>
        /// returns acceleration in metres per frame
        /// </summary>
        /// <param name="framerate">framerate in fps</param>
        /// <returns>double</returns>
        public double Acceleration(double framerate) => ((double)ACCELERATION / framerate);

        /// <summary>
        /// returns retardation in metres per frame
        /// </summary>
        /// <param name="framerate"></param>
        /// <returns></returns>
        public double Retardation(double framerate) => ((double)RETARDATION / framerate);

        /// <summary>
        /// Configure Vehicle Specifications
        /// </summary>
        /// <param name="model">Vehicle Model Name</param>
        /// <param name="topSpeed">Top Speed of Vehicle in [m/s]</param>
        /// <param name="acceleration">Acceleration of Vehicle in [m/ss]</param>
        /// <param name="retardation">Retardation of Vehicle in [m/ss]. Leave blank or as 0 to use same value of acceleration</param>
        public VehicleSpecs(string model, byte topSpeed, byte acceleration, byte retardation = 0)
        {
            ModelName = model;
            TOPSPEED = topSpeed;
            ACCELERATION = acceleration;
            RETARDATION = (retardation != 0 ? retardation : acceleration);
        }
    }
}
