using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
   
    public static class LargestNumberInArray
    {
        //sample  input -> int[]arr ={10,34,47,80, 6785};
        public static int GetLargestNumberInArray(int[] arr)
        {
          
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;

        }
    }
}
