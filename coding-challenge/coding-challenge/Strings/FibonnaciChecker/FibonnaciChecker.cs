using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.FibonnaciChecker
{
    public class FibonnaciChecker
    {
        public static string FibonnaciCheck(int num)
        {
            if(num == 0 || num == 1)
            {
                return "yes";
            }
            int sum1 = 0;
            int sum2 = 1;
            int sumAxlr = 0;

            while(sum2 <= num)
            {
                sumAxlr = sum1 + sum2;
                sum1 = sum2;
                sum2 = sumAxlr;
                if(sum2 == num)
                {
                    return "yes";
                }
            }

            return "no";
        }
    }
}
