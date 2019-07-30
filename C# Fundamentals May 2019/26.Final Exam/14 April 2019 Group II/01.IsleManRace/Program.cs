using System;
using System.Text.RegularExpressions;

namespace _01.IsleManRace
{
    class Program
    {
        static void Main()
        {
            var pattern = new Regex(@"^([#$%*&])(?<racer>\w+)\1=(?<length>\d+)!!(?<hash>.*)$");

            while (true)
            {
                string line = Console.ReadLine();

                var match = pattern.Match(line);

                if (match.Success)
                {
                    var racer = match.Groups["racer"].Value;
                    var length = int.Parse(match.Groups["length"].Value);
                    var hash = match.Groups["hash"].Value;

                    if (length == hash.Length)
                    {
                        string result = string.Empty;

                        for (int i = 0; i < hash.Length; i++)
                        {
                            result += (char)(hash[i] + length);
                        }

                        Console.WriteLine($"Coordinates found! {racer} -> {result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
