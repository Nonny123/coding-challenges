using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_challenge.ExercismChallenges.StringBuilder
{
    public static class Identifier
    {
        public static string Clean(string identifier)
        {
            return identifier.Replace(" ", "_");
        }
    }
}
