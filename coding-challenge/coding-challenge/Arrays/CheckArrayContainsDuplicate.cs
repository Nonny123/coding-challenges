using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    class CheckArrayContainsDuplicate
    {
        public static bool CheckDuplicate(int[] arr, int target)
        {

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {

                        int sum = arr[i] + arr[j];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;

        }
    }
}
