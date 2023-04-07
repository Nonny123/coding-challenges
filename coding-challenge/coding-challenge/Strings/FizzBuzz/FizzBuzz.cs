using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.FizzBuzz
{
    public class FizzBuzz
    {
        public static string StrFizzBuzz(int num)
        {
            if (num == 0) return "0";
            string str = "1";

            for(int i = 2; i <= num; i++)
            {
                str += "";
                if(i % 3 == 0 && i % 5 == 0)
                {
                    str += "FizzBuzz"; continue;
                }
                if(i % 3 == 0)
                {
                    str += "Fizz"; continue;
                }
                if (i % 5 == 0)
                {
                    str += "Buzz"; continue;
                }
                str += i.ToString();
            }

            return str;
        }
    }
}
