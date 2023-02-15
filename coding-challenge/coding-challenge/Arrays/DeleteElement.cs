using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class DeleteElement
    {
        public static int[] DeleteElementInArray(int[] arr)
        {

            int i, j, k;

            int arrLength = arr.Length;



            for (i = 0; i < arr.Length; i++)
            {

                for (j = i + 1; j < arr.Length; j++)
                {
                    //if any duplicate record
                    if (arr[i] == arr[j])
                    {
                        //delete duplicate
                        for (k = j; k < arrLength - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                            //decrease size after removing duplicate
                            arrLength--;
                            //if shifting of element occurs then don't increment
                            j--;
                        }
                    }
                }

                //print array after deleting duplicate elements
                string res = "";
                for (i = 0; i < arr.Length; i++)
                {
                    res += arr[i] + ",";
                }

                string trimmedStr = res.TrimEnd(',');

                //return trimmedStr;

                int[] arrConv = Array.ConvertAll<string, int>(trimmedStr.Split(','), Convert.ToInt32);

                return arrConv;





            }
        }
}
