using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.RemoveBrackets
{
    public class RemoveBrackets
    {
        public static string RemoveBracketsInString(string str)
        {
            while(str.Contains("()"))
            {
                str = str.Replace("()", "");
            }
            str = str.Length.ToString();
            return str;
        }
    }
}
