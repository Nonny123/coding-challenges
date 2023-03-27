using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.DuplicateCharacters
{
    public class DuplicateCharacters
    {
        public static StringBuilder GetDuplicateCharacter(string s)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder Char = new StringBuilder();

            foreach(var item in s)
            {
                if(str.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    str.Append(item);
                }
                else
                {
                    Char.Append(item);
                }
            }
            return Char;
        }
    }
}
