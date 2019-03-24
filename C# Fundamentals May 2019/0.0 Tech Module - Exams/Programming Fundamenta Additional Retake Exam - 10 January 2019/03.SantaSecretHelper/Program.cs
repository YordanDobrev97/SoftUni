using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.SantaSecretHelper
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            string patternName = @"(\@[A-Z][a-z]+)";
            string patternBehaviourType = @"\b(!G!)";

            List<string> names = new List<string>();

            while (input != "end")
            {
                string message = input;
                string decryptMessage = DecryptMessage(message,n);

                var matchName = Regex.Match(decryptMessage, patternName);
                var matchBehavior = Regex.Match(decryptMessage, patternBehaviourType);

                if (matchName.Success && matchBehavior.Success)
                {
                    string name = matchName.Value.Substring(1, matchName.Length - 1);
                    names.Add(name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", names));
        }

        private static string DecryptMessage(string message, int n)
        {
            StringBuilder result = new StringBuilder();

            foreach (char symbol in message)
            {
                char newValueSymbol = (char)(symbol - n);
                result.Append(newValueSymbol);
            }

            return result.ToString();
        }
    }
}
