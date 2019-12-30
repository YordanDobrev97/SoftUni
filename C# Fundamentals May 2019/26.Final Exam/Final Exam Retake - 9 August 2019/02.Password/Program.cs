using System;
using System.Text.RegularExpressions;

namespace _02.Password
{
    class Program
    {
        static void Main()
        {
            int countLines = int.Parse(Console.ReadLine());

            var regex = @"^(.+)>(\d+)\|([a-z]+)\|([A-Z]+)\|(.+)<\1$";
            for (int i = 0; i < countLines; i++)
            {
                string line = Console.ReadLine();

                var match = Regex.Match(line, regex);

                if (match.Success)
                {
                    var firstGroup = match.Groups[2].Value;
                    var secondGroup = match.Groups[3].Value;
                    var thirdGroup = match.Groups[4].Value;
                    var fourtyGroup =match.Groups[5].Value;
                   
                    Console.WriteLine($"Password: {firstGroup}{secondGroup}{thirdGroup}{fourtyGroup}");

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
