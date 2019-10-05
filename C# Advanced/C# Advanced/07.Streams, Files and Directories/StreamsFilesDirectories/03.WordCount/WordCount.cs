using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            var words = new Dictionary<string, int>();

            using (var readerWords = new StreamReader("words.txt"))
            {
                int count = 0;
                var currentWord = readerWords.ReadLine().ToLower().Split();

                foreach (var word in currentWord)
                {
                    using (var readerText = new StreamReader("text.txt"))
                    {
                        while (true)
                        {
                            var text = readerText.ReadLine();

                            if (text == null)
                            {
                                break;
                            }

                            var parts = text.ToLower().Split(new[] { ' ', ',', '-', '.' }
                                 , StringSplitOptions.RemoveEmptyEntries);
                            foreach (var item in parts)
                            {
                                if (item == word)
                                {
                                    count++;
                                }
                            }
                        }

                        if (!words.ContainsKey(word))
                        {
                            words.Add(word, count);
                            count = 0;
                        }
                        else
                        {
                            words[word] += count;
                        }
                    }
                }
            }

            using (var writer = new StreamWriter("Output.txt"))
            {
                foreach (var word in words.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key}-{word.Value}");
                }
            }
        }
    }
}
