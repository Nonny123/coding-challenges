using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class InsertElement
    {
        public static List<int> InsertElementInErray(int[] arr, int element, int position)
        {

            int i = 0;
            int size = arr.Length;
            int[] arr2;
            
            if(position > size + 1 || position <= 0)
           

            for (i = 0; i < arr.Length; i++)
            {
                unique = true;
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
