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

            if (position > size + 1 || position <= 0)
            {
                //console
            }
            else 
            {
                arr2 = new int[size + 1];
                for (i = size; i >= position; i--)
                {
                    arr2[i] = arr[i - 1];
                }

                arr2[position - 1] = element;
                size++;

                for (i = 0; i < position - 1; i++)
                {
                    arr2[i] = arr[i];
                }

                for (i = 0; i < size; i++)
                {
                    Console.Write("{0}\t",arr2[i]);
                }

            }

        }

        
    }
}
