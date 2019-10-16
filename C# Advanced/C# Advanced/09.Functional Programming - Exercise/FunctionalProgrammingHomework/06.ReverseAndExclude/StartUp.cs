using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int[], List<int>> reversed = collection =>
            {
                List<int> reversedNumbers = new List<int>();
                for (int i = collection.Length - 1; i >= 0; i--)
                {
                    reversedNumbers.Add(collection[i]);
                }
                return reversedNumbers;
            };

            List<int> reversedElements = reversed(numbers);

            Action<List<int>> removeElements = x =>
            {
                x.RemoveAll(y => y % n == 0);
            };

            removeElements(reversedElements);

            Action<List<int>> print = elements =>
            {
                Console.WriteLine(string.Join(" ", elements));
            };

            print(reversedElements);
        }
    }
}
