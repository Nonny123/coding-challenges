using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    
    public static class GetUniqueinArray
    {
        //input -> int[] arr = { 10, 34, 47, 47, 80 };
        public static List<int> UniqueinArray(int[] arr)
        {

            int i,j;
            bool unique;
            List<int> uniqueElements = new List<int>();

            for (i = 0; i < arr.Length; i++)
            {
                unique = true;
                for (j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        unique = false;
                        break;
                    }
                }
                if(unique)
                {
                    uniqueElements.Add(arr[i]);                  
                }
            }

            return uniqueElements;

        }
    }
}
