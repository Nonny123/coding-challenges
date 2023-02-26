using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class MultidimensionArray
    {
        public void CreateMultidimensionArray()
        {

            int[,] a = new int[4,3] //4 rows, 3 columns
            { { 27, 31, 40 },
              { 50, 30, 20},
              { 37, 9,10 },
              { 37, 9, 10 } 
            };

            //read array
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(a[i,j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

        }
    }
}
