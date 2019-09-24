using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    public class SetsOfElements
    {
        public static void AddNumbersInSet(HashSet<int> set, int length)
        {
            for (int i = 0; i < length; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
        }

        public static void Main()
        {
            int[] inputData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = inputData[0];
            int m = inputData[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            AddNumbersInSet(firstSet, n);
            AddNumbersInSet(secondSet, m);

            HashSet<int> repeatingValues = new HashSet<int>();
            foreach (var value in firstSet)
            {
                if (secondSet.Contains(value))
                {
                    repeatingValues.Add(value);
                }
            }

            Console.WriteLine(string.Join(" ", repeatingValues));
        }
    }
}
