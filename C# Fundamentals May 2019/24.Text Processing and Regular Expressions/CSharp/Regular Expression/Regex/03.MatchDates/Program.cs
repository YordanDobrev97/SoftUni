using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            //\b(?<day>\d{2})(?<sep>[\/|-|.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string pattern = @"\b(?<day>\d{2})(?<sep>[-|.|\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match match in matchCollection)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
