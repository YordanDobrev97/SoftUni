using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.MemoryView
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            List<string> words = new List<string>();
            while (line != "Visual Studio crash")
            {
                List<string> splitedInput = line.Split(new char[] {' '}, 
                    StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x != "0").ToList();

                int index = (splitedInput.IndexOf("32763")) + 2;

                string result = string.Empty;
                for (int i = index; i < splitedInput.Count; i++)
                {
                    int value = int.Parse(splitedInput[i]);
                    result += (char)value;
                }
                words.Add(result);

                line = Console.ReadLine();
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}