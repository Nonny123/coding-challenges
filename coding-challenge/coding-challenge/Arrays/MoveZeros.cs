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
                arr[i] = arr[i + 1];
            }
            
        }
    }
}
