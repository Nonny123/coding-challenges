using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace coding_challenge.Strings.VowelCount
{
    public class VowelCount
    {
        public static int CountVowelsInAStirng(string str)
        {
            var regex = new Regex("a|e|i|o|u");
            return regex.Matches(str).Count;
        }
    }
}
