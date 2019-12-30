using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04Enigma
{
    class Program
    {
        static void Main()
        {
            var pattern = @"@([a-zA-Z]+)[^@\-!:>]*\:([0-9]+)[^@\-!:>]*\!(A|D)\![^@\-!:>]*\-\>[0-9]+";
            var patternOfLetters = @"[star]";

            RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;
            var countOfMessage = int.Parse(Console.ReadLine());

            List<string> decryptMessages = new List<string>();
            for (int i = 0; i < countOfMessage; i++)
            {
                var message = Console.ReadLine();

                var matches = Regex.Matches(message, patternOfLetters, options);
                int countMatches = matches.Count;

                StringBuilder sb = new StringBuilder();

                foreach (var symbol in message)
                {
                    sb.Append((char)(symbol - countMatches));
                }

                decryptMessages.Add(sb.ToString());
            }

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            foreach (var message in decryptMessages)
            {
                if (Regex.IsMatch(message, pattern))
                {
                    var match = Regex.Match(message, pattern);

                    var planet = match.Groups[1].Value;
                    var attack = match.Groups[3].Value;

                    switch (attack)
                    {
                        case "A":
                            attackedPlanets.Add(planet);
                            break;
                        case "D":
                            destroyedPlanets.Add(planet);
                            break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            PrintPlanets(attackedPlanets);

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            PrintPlanets(destroyedPlanets);
        }

        private static void PrintPlanets(List<string> planets)
        {
            planets.Sort();
            foreach (var planet in planets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
