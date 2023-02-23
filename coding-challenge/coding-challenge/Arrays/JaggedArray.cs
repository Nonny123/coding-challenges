using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Arrays
{
    public class JaggedArray
    {
        public void CreateJaggedArray()
        {

            int[][] a = new int[4][]; //4 rows, columns unknown
            a[0] = new int[3] { 27, 31, 40 };
            a[1] = new int[4] { 50, 30, 20, 67 };
            a[2] = new int[2] { 20, 90 };
            a[3] = new int[5] { 37, 9, 10,44, 80 };

            //read array
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine(a[i][j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

        }
    }
}
