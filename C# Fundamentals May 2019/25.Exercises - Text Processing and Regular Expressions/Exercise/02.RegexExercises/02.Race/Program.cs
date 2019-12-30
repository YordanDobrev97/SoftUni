using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main()
        {
            var participants = Console.ReadLine()
                .Split(", ");

            var patternName = @"[A-Za-z]";
            var patternDigits = @"\d";

            var validNames = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "end of race")
            {
                var matchesName = Regex.Matches(input, patternName);
                var matchesDigits = Regex.Matches(input, patternDigits);

                StringBuilder sb = new StringBuilder();
                foreach (Match match in matchesName)
                {
                    sb.Append(match.Value);
                }

                int sum = 0;

                foreach (Match matchDigit in matchesDigits)
                {
                    int digit = int.Parse(matchDigit.Value);
                    sum += digit;
                }

                if (participants.Contains(sb.ToString()))
                {
                    var name = sb.ToString();
                    if (!validNames.ContainsKey(name))
                    {
                        validNames[name] = 0;
                    }
                    validNames[name] += sum;
                }

                input = Console.ReadLine();
            }

            validNames = validNames.OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x => x.Key, v => v.Value);

            var top = validNames.Keys.ToList();
            Console.WriteLine($"1st place: {top[0]}");
            Console.WriteLine($"2nd place: {top[1]}");
            Console.WriteLine($"3rd place: {top[2]}");
        }
    }
}
