using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            Console.
                WriteLine(
                string.Join(", ", Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray()));
        }
    }
}
