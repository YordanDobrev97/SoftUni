using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SkipTakeRope
{
    class Program
    {
        static List<int> GetDigits(char[] characters)
        {
            List<int> digits = new List<int>();

            foreach (var item in characters)
            {
                bool isNumber = int.TryParse($"{item}", out int num);

                if (isNumber)
                {
                    digits.Add(num);
                }
            }

            return digits;
        }

        private static List<char> GetNotDigits(char[] characters)
        {
            List<char> result = new List<char>();

            foreach (var item in characters)
            {
                bool isDigit = int.TryParse($"{item}", out int num);

                if (!isDigit)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        static void Main()
        {
            string line = Console.ReadLine();

            char[] characters = line.ToCharArray();
            List<int> digts = GetDigits(characters);
            List<char> notDigits = GetNotDigits(characters);

            string message = string.Empty;
            
            for (int i = 0; i < digts.Count; i+=2)
            {
                int skip = digts[i];
                int take = digts[i + 1];

                var elements = notDigits.Take(take).Skip(skip).ToList();
                Console.WriteLine();
            }
        }
    }
}
