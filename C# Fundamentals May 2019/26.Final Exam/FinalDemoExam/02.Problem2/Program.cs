using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Problem2
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .Where(x => x.Contains(":"))
                .ToArray();

            var pattern = new Regex(@":([,\.!?]*[a-z]{4,}[,\.!?]*):");

            List<string> validEmoji = new List<string>();
            foreach (var item in input)
            {
                var isValid = pattern.Match(item);

                if (isValid.Success)
                {
                    if (isValid.Groups[0].Length == item.Length)
                    {
                        validEmoji.Add(item);
                    }
                }
            }

            int emojiCode = Console.ReadLine()
                .Split(":")
                .Select(int.Parse)
                .ToArray()
                .Sum();

            int totalPower = 0;

            validEmoji.Reverse();

            foreach (var emoji in validEmoji)
            {
                int sum = 0;
                for (int i = 1; i < emoji.Length - 1; i++)
                {
                    sum += emoji[i];
                }

                totalPower += sum;
                if (sum == emojiCode)
                {
                    totalPower *= 2;
                }

            }

            if (validEmoji.Count != 0)
            {
                validEmoji.Reverse();
                Console.WriteLine($"Emojis found: {string.Join(", ", validEmoji)}");
            }

            Console.WriteLine($"Total Emoji Power: {totalPower}");
        }
    }
}
