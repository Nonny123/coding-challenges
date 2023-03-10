using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.HighestOccurence
{
    public class HighestOccurrenceInString
    {
        public static char GetHighestOccuringChar(string s)
        {
            int CHAR_SIZE = 256;
            int[] arrCount = new int[CHAR_SIZE];
            int strLength = s.Length;
            for(int i = 0; i < strLength; i++)
            {
                arrCount[s[i]]++;
            }
            int maxVal = -1;
            char res = '';

            for (int i = 0; i < strLength; i++)
            {
                arrCount[s[i]]++;
            }

        }
    }
}
