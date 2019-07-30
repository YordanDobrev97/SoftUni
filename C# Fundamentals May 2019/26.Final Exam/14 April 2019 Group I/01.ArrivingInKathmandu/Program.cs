using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01.ArrivingInKathmandu
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            var pattern = @"^([A-Za-z0-9!@#$?]+)=(\d+)<<(.+)$";

            while (line != "Last note")
            {
                var match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    var name = match.Groups[1].Value;
                    var length = int.Parse(match.Groups[2].Value);
                    var hashCode = match.Groups[3].Value;

                    if (length == hashCode.Length)
                    {
                        name = Regex.Replace(name, "[!@#$?]", "");
                        Console.WriteLine($"Coordinates found! {name} -> {hashCode}");
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

                line = Console.ReadLine();
            }
        }
    }
}
