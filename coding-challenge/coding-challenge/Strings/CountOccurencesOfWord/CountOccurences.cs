using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.CountOccurencesOfWord
{
    public class CountOccurences
    {
        public static int CountOccurencesInSentence(string str, string word)
        {
            string[] a = str.Split(' ');
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (word.Equals(a[i])) count++;
            }

            return count;
        }
    }
}
