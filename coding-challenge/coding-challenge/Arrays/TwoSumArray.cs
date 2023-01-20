using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public static class TwoSumArray
    {
        public static List<int> TwoIntegersSumTarget(int[] arr, int target)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                       
                        break;
                    }
                }
               
            }

            return false;

        }
    }
}
