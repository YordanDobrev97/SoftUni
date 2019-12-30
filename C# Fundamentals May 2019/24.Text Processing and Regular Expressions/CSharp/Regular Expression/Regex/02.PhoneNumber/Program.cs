using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.PhoneNumber
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\+359([\s|-])2\1\d{3}\1\d{4}\b";

            RegexOptions options = RegexOptions.Multiline;
            MatchCollection matches = Regex.Matches(input, pattern, options);

            List<string> phones = new List<string>();

            foreach (Match match in matches)
            {
                phones.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
