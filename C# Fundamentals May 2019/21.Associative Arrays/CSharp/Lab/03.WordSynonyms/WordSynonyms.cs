using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    public class WordSynonyms
    {
        public static void Main()
        {
            int countWords = int.Parse(Console.ReadLine());

            var wordSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < countWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms.Add(word, new List<string>());
                }
                wordSynonyms[word].Add(synonym);
            }

            foreach (var word in wordSynonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
