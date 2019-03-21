using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            string[] sequenceWords = Console.ReadLine().
                ToLower()
                .Split();

            var countWords = new Dictionary<string, int>();

            foreach (var word in sequenceWords)
            {
                if (!countWords.ContainsKey(word))
                {
                    countWords.Add(word, 0);
                }
                countWords[word]++;
            }

            foreach (var wordCount in countWords)
            {
                if (wordCount.Value % 2 == 1)
                {
                    Console.Write($"{wordCount.Key} ");
                }
            }

            Console.WriteLine();
        }
    }
}
