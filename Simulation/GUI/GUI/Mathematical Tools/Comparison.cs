using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Mathematical_Tools
{
    public static class Compare
    {
        public static double LargestOf(double[] values)
        {
            double largest = values[0];

            for (int i = 1; i < values.Length; ++i)
                largest = (values[i] > largest ? values[i] : largest);

            return largest;
        }

        public static double LargestOf(double value1, double value2) => (value1 > value2 ? value1 : value2);

        public static double LeastOf(double[] values)
        {
            double least = values[0];

            for (int i = 1; i < values.Length; ++i)
                least = (values[i] < least ? values[i] : least);

            return least;
        }

        public static double LeastOf(double value1, double value2) => (value1 < value2 ? value1 : value2);

        public static bool IsInBetween(double value, double limit1, double limit2) => ((value <= LargestOf(limit1, limit2)) && (value >= LeastOf(limit1, limit2))) ? true : false;
    }
}
