using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05Realms
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(", ");

            List<string> result = new List<string>();
            foreach (var item in input)
            {
                double healt = GetHealt(item);
                double damage = GetDamange(item);

                result.Add($"{item} - {healt} health, {damage:f2} damage");
            }

            result.Sort();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int GetHealt(string input)
        {
            var matches = new Regex(@"([a-zA-z])(\+\-\*\/)*");

            var matchesHealt = matches.Matches(input);
            int totalHealt = 0;
            foreach (Match matchHealt in matchesHealt)
            {
                char symbol = char.Parse(matchHealt.Value);
                totalHealt += symbol;
            }

            return totalHealt;
        }

        private static double GetDamange(string input)
        {
            var patternNumber = new Regex(@"[-]?[0-9]*\.[0-9]+|[0-9]+");
            var patternSign = new Regex(@"[\*|\/]");


            var matchesNumbers = patternNumber.Matches(input);
            var matchesSing = patternSign.Matches(input);

            double sum = 0;

            foreach (Match matchNumber in matchesNumbers)
            {
                double num = double.Parse(matchNumber.Value);
                sum += num;
            }

            foreach (Match matchSign in matchesSing)
            {
                if (matchSign.Value == "*")
                {
                    sum *= 2;
                }
                else if (matchSign.Value == "/")
                {
                    sum /= 2;
                }
            }

            return sum;
        }
    }
}
