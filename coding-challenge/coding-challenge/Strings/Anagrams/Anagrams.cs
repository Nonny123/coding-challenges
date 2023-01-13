using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.Strings.Anagrams
{
    public static class Anagrams
    {

        public void CheckAnagram()
        {
            for (int i = 0; i < T; i++)
            {

                if (!IsEven(s.Length))
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    string a = s.Substring(0, s.Length / 2);
                    string b = s.Substring(s.Length / 2, s.Length / 2);

                    Dictionary<char, int> dictionary = new Dictionary<char, int>();

                    for (int j = 0; j < a.Length; j++)
                    {
                        if (!dictionary.ContainsKey(a[j]))
                            dictionary.Add(a[j], 0);

                        dictionary[a[j]]++;
                    }

                    for (int j = 0; j < b.Length; j++)
                    {
                        if (!dictionary.ContainsKey(b[j]))
                            dictionary.Add(b[j], 0);

                        dictionary[b[j]]--;
                    }

                    int sum = 0;

                    foreach (KeyValuePair<char, int> keyValuePair in dictionary)
                    {
                        sum += Math.Abs(keyValuePair.Value);
                    }
                }
            }
   
}
