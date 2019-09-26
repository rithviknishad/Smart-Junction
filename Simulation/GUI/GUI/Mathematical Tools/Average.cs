using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Mathematical_Tools
{
    public class Average
    {
        public double AverageValue { get; private set; } = 0;
        public double Count { get; private set; } = 0;

        public Average(double avgValue = 0, double count = 0)
        {
            if (count != 0)
            {
                AverageValue = avgValue;
                Count = count;
            }
        }

        public Average(Average toCopy)
        {
            AverageValue = toCopy.AverageValue;
            Count = toCopy.Count;
        }

        public void Add(double value) => AverageValue = ((AverageValue * Count) + value) / (++Count);

        public void Add(double[] values)
        {
            double unpacked = AverageValue * Count;

            foreach(double value in values)
            {
                unpacked += value;
            }

            AverageValue = unpacked / (Count += (ulong)values.Length);
        }

        public void Reset() => AverageValue = Count = 0;


        public static Average operator +(Average left, Average right)
        {
            double unpackedL = left.AverageValue * left.Count;
            double unpackedR = right.AverageValue * right.Count;

            return new Average((unpackedL + unpackedR) / (left.Count + right.Count), left.Count + right.Count);
        }
    }
}
