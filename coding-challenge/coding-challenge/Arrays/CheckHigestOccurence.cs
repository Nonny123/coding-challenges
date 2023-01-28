using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class CheckHigestOccurence
    {
        public static bool MostFrequentNumbers(int[] arr, Dictionary<string, int> dict)
        {

            List<int> intList = new List<int>();
            foreach (int i in arr)
            {
                string key = i.ToString();
                if (dict.ContainsKey(key))
                    dict[key] += 1;
                else dict[key] = 1;
            }

            return false;

        }
    }
}
