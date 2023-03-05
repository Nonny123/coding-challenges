using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.UniqueCharacters
{
    public class UniqueCharacters
    {
        public static List<char> UniqueList(string s)
        {
            List<char> chars = new List<char>();
            foreach(char c in s)
            {
                if(!chars.Contains(c))
                {
                    chars.Add(c);
                }
            }

            return chars;
        }
    }
}
