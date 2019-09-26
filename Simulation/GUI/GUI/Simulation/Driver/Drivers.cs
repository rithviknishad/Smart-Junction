namespace GUI.Simulation.Drivers
{
    public static class WorldDrivers
    {
        public static Driver[] DriverList =
        {
            new Driver(22, 0.6),
            new Driver(20, 0.55),
            new Driver(18, 0.45),
            new Driver(16, 0.41),
            new Driver(17, 0.38),
            new Driver(19, 0.33)
        };

        public static Driver GetRandomDriver()
        {
            return DriverList[Tools.RandomNumber(DriverList.Length)];
        }
    }

}
