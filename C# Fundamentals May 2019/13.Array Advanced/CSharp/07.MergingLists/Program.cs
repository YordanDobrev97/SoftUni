using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MergingLists
{
    class Program
    {
        static void Main()
        {
            List<int> firstNumbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            List<int> secondNumbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            List<int> result = new List<int>();

            int i = 0;

            while (firstNumbers.Count > 0 && secondNumbers.Count > 0)
            {
                int first = firstNumbers[i];
                int second = secondNumbers[i];

                result.Add(first);
                result.Add(second);

                firstNumbers.RemoveAt(i);
                secondNumbers.RemoveAt(i);
            }

            if (firstNumbers.Count > 0)
            {
                result.AddRange(firstNumbers);
            }

            if (secondNumbers.Count > 0)
            {
                result.AddRange(secondNumbers);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
