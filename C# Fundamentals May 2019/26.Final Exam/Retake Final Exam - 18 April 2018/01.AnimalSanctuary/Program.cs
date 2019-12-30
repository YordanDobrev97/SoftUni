using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.AnimalSanctuary
{
    class Program
    {
        static string GetOnlyLetters(string letter)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < letter.Length; i++)
            {
                if (char.IsLetter(letter[i]) || letter[i] == ' ')
                {
                    sb.Append(letter[i]);
                }
            }

            return sb.ToString();
        }

        static void Main()
        {
            int numberLines = int.Parse(Console.ReadLine());

            var pattern = new Regex(@"n:(?<name>[^;]*);t:(?<kind>[^;]*);c--(?<country>[a-zA-Z\s]*$)");

            var patternForDigits = new Regex(@"\d");

            var totalWeigth = 0;

            for (int i = 0; i < numberLines; i++)
            {
                var message = Console.ReadLine();

                var match = pattern.Match(message);

                if (match.Success)
                {
                    var name = match.Groups["name"].Value;
                    var letters = GetOnlyLetters(name);

                    var kind = match.Groups["kind"].Value;
                    var kindLetters = GetOnlyLetters(kind);

                    var country = match.Groups["country"].Value;
                    country = GetOnlyLetters(country);

                    var sum = patternForDigits.Matches(message)
                        .Select(x => int.Parse(x.Value)).ToList().Sum();

                    totalWeigth += sum;
                    Console.WriteLine($"{letters} is a {kindLetters} from {country}");
                }
            }

            Console.WriteLine($"Total weight of animals: {totalWeigth}KG");
        }
    }
}
