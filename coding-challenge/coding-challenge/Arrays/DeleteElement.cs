using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class DeleteElement
    {
        public static void DeleteElementInArray(int[] arr, int element, int position)
        {

            int i = 0;

            int size = arr.Length;
            if(position < 0 || position > size)
            {
                Console.Write("Invalid position. Enter a position between 1 to {0}", size);
            }
            else
            {
                //copy next element value to current element
                for(i = position - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                //dercrese array size by 1
                size--;
            }

            for (i = 0; i < size; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }



        }
    }
}
