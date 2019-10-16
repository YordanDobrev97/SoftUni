using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    public class StartUp
    {
        public static void Main()
        {
            Func<string, bool> toUpper = x => x[0] == x.ToUpper()[0];

            var textItems = Console.ReadLine().Split(" ", 
                StringSplitOptions.RemoveEmptyEntries)
                .Where(toUpper)
                .ToList();

            foreach (var item in textItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
