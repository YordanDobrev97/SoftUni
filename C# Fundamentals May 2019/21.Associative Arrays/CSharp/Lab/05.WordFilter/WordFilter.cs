using System;
using System.Linq;

namespace _05.WordFilter
{
    public class WordFilter
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            string[] specialWords = words.Where(x => x.Length % 2 == 0).ToArray();

            foreach (var word in specialWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
