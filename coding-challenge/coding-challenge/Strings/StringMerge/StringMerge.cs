using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.StringMerge
{
    public class StringMerge
    {
        public static string MergeString(string str)
        {
            string newStr = "";
            int half = str.Length / 2;
            for(int i = 0; i < half; i++)
            {
                newStr += str[i].ToString() + str[i + half + 1].ToString();
                    
            }
            return newStr;
        }
    }
}
