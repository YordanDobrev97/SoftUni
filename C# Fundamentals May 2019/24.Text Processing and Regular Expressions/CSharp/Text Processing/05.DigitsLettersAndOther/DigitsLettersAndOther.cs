using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.DigitsLettersAndOther
{
    public class DigitsLettersAndOther
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string patternDigits = @"[0-9]+";
            string patternLetters = @"[A-Z][a-z]*";
            string patternOthers = @"\W";

            var digits = new List<string>();
            var letters = new List<string>();
            var others = new List<string>();

            Matches(input, patternDigits, digits);
            Matches(input, patternLetters, letters);
            Matches(input, patternOthers, others);

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", others));
        }

        public static void Matches(string input, string pattern, List<string> collection)
        {
            foreach (Match m in Regex.Matches(input, pattern))
            {
                collection.Add(m.Value);
            }
        }
    }
}
