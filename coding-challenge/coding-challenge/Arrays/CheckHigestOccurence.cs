using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class CheckHigestOccurence
    {
        public static List<int> MostFrequentNumbers(int[] arr, Dictionary<string, int> dict)
        {

            List<int> intList = new List<int>();
            foreach (int i in arr)
            {
                string key = i.ToString();
                if (dict.ContainsKey(key))
                    dict[key] += 1;
                else dict[key] = 1;
            }

            string firstStringElement = arr[0].ToString();
            int mostCount = dict[firstStringElement];

            foreach(string s in dict.Keys)
            {
                if(dict[s] > mostCount)
                {
                    mostCount = dict[s];
                }
            }

            foreach (string s in dict.Keys)
            {
                if (dict[s] == mostCount)
                {
                    intList.Add(int.Parse(s));
                }
            }

            return intList;

        }
    }
}
