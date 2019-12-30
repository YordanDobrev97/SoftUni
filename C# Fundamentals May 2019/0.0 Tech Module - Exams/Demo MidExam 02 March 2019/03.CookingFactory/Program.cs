using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CookingFactory
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            var breadQuanity = new Dictionary<string, int>();

            while (line != "Bake It!")
            {
                string[] arguments = line.Split('#');
                int sum = arguments.Select(int.Parse).ToArray().Sum();

                if (!breadQuanity.ContainsKey(line))
                {
                    breadQuanity.Add(line, sum);
                }

                line = Console.ReadLine();
            }

            int currentBiggest = 0;
            string sequence = string.Empty;

            foreach (var item in breadQuanity)
            {
                if (item.Value == currentBiggest)
                {
                    int length = item.Key.Split('#').Length;
                    int prevLength = sequence.Split('#').Length;
                    int currentAverage = item.Value / length;
                    int prevAverage = item.Value / prevLength;
                    if (currentAverage > prevAverage)
                    {
                        currentBiggest = currentAverage;
                        sequence = item.Key;
                    }                    
                }
                else if (item.Value > currentBiggest)
                {
                    currentBiggest = item.Value;
                    sequence = item.Key;
                }
            }

            Console.WriteLine($"Best Batch quality: {currentBiggest}");
            Console.WriteLine($"{string.Join(" ",sequence.Split('#'))}");
        }
    }
}
