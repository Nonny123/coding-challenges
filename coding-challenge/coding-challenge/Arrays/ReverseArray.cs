using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class ReverseArray
    {
        public static bool ReverseArrayElements(params int[] x)
        {

            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int i in x)
            {
                if (d.ContainsKey(i))
                    return true;
                else d.Add(i, 1);
            }

            return false;

        }
    }
}
