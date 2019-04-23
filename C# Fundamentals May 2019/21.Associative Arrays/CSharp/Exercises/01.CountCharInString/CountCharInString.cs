using System;
using System.Collections.Generic;

namespace _01.CountCharInString
{
    public class CountCharInString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var countCharsInString = new Dictionary<char, int>();

            foreach (var symbol in input)
            {
                if (symbol != ' ')
                {
                    if (!countCharsInString.ContainsKey(symbol))
                    {
                        countCharsInString.Add(symbol, 0);
                    }
                    countCharsInString[symbol]++;
                }
            }

            foreach (var kvp in countCharsInString)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
