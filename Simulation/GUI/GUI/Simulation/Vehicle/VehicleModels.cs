namespace GUI.Simulation.Vehicles
{
    public static class VehicleModels
    {
        public static VehicleSpecs[] Cars =
        {
            new VehicleSpecs("TESLA-ROADSTER", 111, 14),
            new VehicleSpecs("MITSUBISHI PAJERO", 47, 5),
            new VehicleSpecs("VOLKSWAGEN-POLO", 66, 10)
        };

        public static VehicleSpecs GetRandomCar()
        {
            return Cars[Tools.RandomNumber(Cars.Length)];
        }
    }
}
