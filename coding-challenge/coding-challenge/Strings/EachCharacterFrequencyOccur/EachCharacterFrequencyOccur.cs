using System;
using System.Collections.Generic;


namespace coding_challenge.Strings.EachCharacterFrequencyOccur
{
    public class EachCharacterFrequencyOccur
    {
        public static List<char> CharacterFrequency(string s)
        {
            List<char> chars = new List<char>();
            foreach (char c in s)
            {
                if (!chars.Contains(c))
                {
                    chars.Add(c);
                }
            }

            return chars;
        }
    }
}
