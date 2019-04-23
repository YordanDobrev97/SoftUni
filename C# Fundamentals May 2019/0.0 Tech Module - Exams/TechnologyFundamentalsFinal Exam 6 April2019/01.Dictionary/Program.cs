using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var descriptionsWords = Console.ReadLine()
                 .Split('|');

            var words = Console.ReadLine()
                 .Split('|');

            var line = Console.ReadLine();

            var wordsWithDescriptions = new Dictionary<string, List<string>>();

            foreach (var word in descriptionsWords)
            {
                var currentWord = word.Split(':')[0];
                var listWords = word.Split(':').Take(word.Length - 1).ToList();

                if (!wordsWithDescriptions.ContainsKey(currentWord))
                {
                    wordsWithDescriptions.Add(currentWord, listWords);
                }
                else
                {
                    foreach (var item in listWords)
                    {
                        wordsWithDescriptions[currentWord].Add(item);
                    }
                }
            }

            if (line == "List")
            {
                var keys = wordsWithDescriptions.OrderBy(x => x.Key)
                    .ToDictionary(x => x.Key, v => v.Value);

                Console.WriteLine(string.Join(" ", keys.Keys).Trim());
            }
        }
    }
}
