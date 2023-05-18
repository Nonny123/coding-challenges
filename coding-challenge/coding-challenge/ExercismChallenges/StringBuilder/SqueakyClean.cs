using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.ExercismChallenges.StringBuilderExercises
{
    public static class Identifier
    {
        public static string Clean(string identifier)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < identifier.Length; i++)
            {

                char c = identifier[i];

                if (c == ' ')
                {
                }




                    return identifier.Replace(" ", "_");
        }
    }
}
