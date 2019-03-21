using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var countNumbers = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!countNumbers.ContainsKey(number))
                {
                    countNumbers.Add(number, 0);
                }
                countNumbers[number]++;
            }

            countNumbers = countNumbers.
                OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, v => v.Value);

            foreach (var kvp in countNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
