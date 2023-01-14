using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public static class SwapMinMax
    {
        public static void MinMaxSwap(int[] x)
        {
            int min = 0;
            int max = 0;

            for (int i = 1; i < x.Length; i++)
            {
                if (x[min] > x[i])
                    min = i;
                if (x[max] < x[i])
                    max = i;
            }

            int temp = x[min];

            x[min] = x[max];
            x[max] = temp;

            Console.WriteLine(x[min]);
            Console.WriteLine(x[max]);

        }
    }
}
