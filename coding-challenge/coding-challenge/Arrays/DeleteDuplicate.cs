using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    class DeleteDuplicate
    {
        public static int[] DeleteDuplicateInArray(int[] arr)
        {

            int i, j, k;

            int arrLength = arr.Length;
            
            

            for (i = 0; i < arr.Length; i++)
            {
               //if any duplicate record
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    uniqueElements.Add(arr[i]);
                }
            }

            return uniqueElements;

        }
    }
}
