using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.PrimeNumbers
{
    public class PrimeNumbers
    {
        public static string Primes(int num)
        {
            if (num < 1) return "false";

            if (num > (int)UInt16.MaxValue + 1) return "false";

            for(int i = 2; i < num/2 + 1; ++i)
            {
                if(num % i == 0) return "false";
            }

            return "true";
        }
    }
}
