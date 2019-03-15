using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int sum = int.Parse(Console.ReadLine());

        HashSet<int> pairs = new HashSet<int>();
        for (int i = 0; i < array.Length; i++)
        {
            int element = array[i];

            //found pairs
            for (int j = 0; j < array.Length; j++)
            {
                int currentElement = array[j];
                int currentSum = element + currentElement;

                if (currentSum == sum)
                {
                    pairs.Add(element);
                    pairs.Add(currentElement);
                    break;
                }
            }
        }

        for (int i = 0; i < pairs.Count; i+=2)
        {
            Console.WriteLine($"{pairs.ElementAt(i)} {pairs.ElementAt(i + 1)}");
        }
    }
}

