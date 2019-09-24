using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> valuesCount = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!valuesCount.ContainsKey(symbol))
                {
                    valuesCount.Add(symbol, 0);
                }

                valuesCount[symbol]++;
            }

            foreach (var item in valuesCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
