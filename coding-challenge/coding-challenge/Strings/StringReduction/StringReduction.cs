using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.StringReduction
{
    public class StringReduction
    {
        public static string StringReduction(string str)
        {
            int a = 0; int b = 0; int c = 0;
            
            foreach(char cc in str)
            {
                if (cc == 'a') a++;
                if (cc == 'b') b++;
                if (cc == 'c') c++;
            }

            int max = 0;

            max = Math.Max(max, Math.Abs(a - b));
        }
    }
}
