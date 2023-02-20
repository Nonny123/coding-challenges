using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public static class ReverseArray
    {
        public static void ReverseArrayElements(int[] arr)
        {

            for(int i = 0; i < arr.Length/2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }

           

        }
    }
}
