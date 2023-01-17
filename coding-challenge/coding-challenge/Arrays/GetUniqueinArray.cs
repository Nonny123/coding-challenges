using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    class 
    {
    }
    public static class GetUniqueinArray
    {

        public static int UniqueinArray(int[] arr)
        {

            int i,j;
            bool unique;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        unique = false;
                }
            }

            //return ;

        }
    }
}
