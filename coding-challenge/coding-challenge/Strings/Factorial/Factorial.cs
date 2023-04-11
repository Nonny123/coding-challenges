using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.Factorial
{
    public class Factorial
    {
        public static double FactorialAlgo(int number)
        {
            if(number == 0) 
            { 
                return 1; 
            }
            else
            {
                return number * FactorialAlgo(number - 1);
            }
        }
    }
}
