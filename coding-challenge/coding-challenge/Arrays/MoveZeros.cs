using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class MoveZeros
    {
        public static void Move(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) ;

                MoveZeroToEnd(arr, i);

            }
            
        }

        private static void MoveZeroToEnd(int[] arr, int index)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;

            }
        }
    }
}
