using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace coding_challenge.Strings.ConsonantCount
{
    public class ConsonantCount
    {
        public static int CountConsonant(string str)
        {
            Regex rgx = new Regex(@"[^a-zA-Z]|[aeiou]", RegexOptions.IgnoreCase);
            int num = rgx.Replace(str, "").Length;
            return num;
        }
    }
}
