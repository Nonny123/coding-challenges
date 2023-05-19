using System;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;


namespace coding_challenge.ExercismChallenges.StringBuilderExercises
{
    public static class Identifier
    {
        public static string Clean(string identifier)
        {
            identifier = Regex.Replace(identifier, @"\s", "_"); //replace any spaces with underscores
            
            identifier = Regex.Replace(identifier, @"-\D", new MatchEvaluator(ConvertToCamelCase)); //convert kebab-case to camelCase - à-ḃç" => "àḂç"

            identifier = Regex.Replace(identifier, "\\0", "CTRL");// replace control characters with the upper case string "CTRL"

            return Regex.Replace(identifier, @"[α-ω]|\d|\W", "");//remove non-letters and Greek letters in the range  'α' to 'ω'
        }


        private static string ConvertToCamelCase(Match mt)
        {
            return mt.Value[1].ToString().ToUpper();
        }

    }
}
