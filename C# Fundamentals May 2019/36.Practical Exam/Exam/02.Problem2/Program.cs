using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Problem2
{
    class Program
    {
        static void Main()
        {
            var pattern = new 
                Regex(@"^(\$|%)([A-Z][a-z]+)\1\: (\[\d+\]\|\[\d+\]\|\[\d+\]\|)$");

            int countMessage = int.Parse(Console.ReadLine());

            for (int i = 0; i < countMessage; i++)
            {
                string message = Console.ReadLine();

                var match = pattern.Match(message);
                if (match.Success)
                {
                    var patternDigits = new Regex(@"\d+");
                    var digits = patternDigits.Matches(match.Groups[3].Value).ToList();

                    string result = string.Empty;

                    foreach (Match digit in digits)
                    {
                        int symbol = int.Parse(digit.Value);
                        result += (char)(symbol);
                    }

                    Console.WriteLine($"{match.Groups[2]}: {result}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
