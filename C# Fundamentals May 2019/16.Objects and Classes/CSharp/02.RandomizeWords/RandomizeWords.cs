using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(' ').ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int randomIndex = random.Next(0, words.Count - 1);
                string currentWord = words[randomIndex];

                int secondRandomIndex = random.Next(0, words.Count - 1);
                string secondWord = words[secondRandomIndex];

                string temp = currentWord;
                words[randomIndex] = words[secondRandomIndex];
                words[secondRandomIndex] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
