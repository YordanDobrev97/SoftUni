using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var currentDirectory = Environment.CurrentDirectory;

        var allWords = File.ReadAllText($"{currentDirectory}/words.txt").Split(Environment.NewLine);
        var textData = File.ReadAllText($"{currentDirectory}/text.txt").Split(Environment.NewLine);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (var word in allWords)
        {
            foreach (var data in textData)
            {
                string[] elements = data.Split(new[] { '.', ' ', ',', '-', '?' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    if (word.ToLower() == element.ToLower())
                    {
                        if (!wordCount.ContainsKey(word))
                        {
                            wordCount.Add(word, 0);
                        }
                        wordCount[word]++;
                    }
                }
            }
        }

        wordCount = wordCount.OrderByDescending(x => x.Key)
            .ToDictionary(x => x.Key, v => v.Value);

        using (var writer = new StreamWriter($"{currentDirectory}/actualResult.txt"))
        {
            foreach (var word in wordCount)
            {
                writer.WriteLine($"{word.Key} - {word.Value}");
            }
        }

    }
}

