using System;
using System.Collections.Generic;
using System.Linq;

namespace coding_challenge.Strings.EachCharacterFrequencyOccur
{
    public class EachCharacterFrequencyOccur
    {
        public static void EachCharacterOccurence(string str)
        {
            var FreQ = from x in str group x by x into y select y;
            foreach (var ArrEle in FreQ)
            {
                Console.WriteLine("Character")
            }

            
        }
    }
}
