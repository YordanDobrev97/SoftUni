using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Dict
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            var words = new Dictionary<string, List<string>>();

            while (true)
            {
                if (line == "End")
                {
                    break;
                }
                else if (line == "List")
                {
                    var wordsKey = words.Keys.ToList();
                    wordsKey.Sort();

                    Console.WriteLine(string.Join(" ", wordsKey));
                    break;
                }
                string[] elements = line.Split(" | ");

                foreach (var element in elements)
                {
                    string word = element;
                    string defination = string.Empty;

                    if (element.Contains(":"))
                    {
                        word = element.Split(": ")[0].Trim();
                        defination = element.Split(": ")[1].Trim();

                        if (!words.ContainsKey(word))
                        {
                            words.Add(word, new List<string>());
                        }

                        if (!words[word].Contains(defination))
                        {
                            words[word].Add(defination);
                        }
                    }
                    else
                    {
                        foreach (var item in elements)
                        {
                            if (!words.ContainsKey(item))
                            {
                                continue;
                            }
                            Console.WriteLine($"{item}");
                            foreach (var definationWord in words[item].
                                OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($" -{definationWord}");
                            }
                        }
                        break;
                    }
                }

                line = Console.ReadLine();
            }


        }
    }
}
