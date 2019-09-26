using System;


namespace GUI.Simulation
{
    public static class Tools
    {

        public static int Seed { get; private set; } = 0;
        private static Random Random = new Random(9987);
        public static int RandomNumber(int range) => Random.Next() % range;

    }
}
