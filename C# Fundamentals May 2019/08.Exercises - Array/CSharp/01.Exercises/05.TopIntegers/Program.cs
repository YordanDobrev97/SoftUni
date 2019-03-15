using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToArray();

        List<int> topIntegers = new List<int>();
        for (int i = 0; i < array.Length - 1; i++)
        {
            int element = array[i];
            bool hasBiggest = false;
            for (int j = i + 1; j < array.Length; j++)
            {
                int nextElement = array[j];

                if (element > nextElement)
                {
                    hasBiggest = true;
                    continue;
                }
                else
                {
                    hasBiggest = false;
                    break;
                }
            }
            if (hasBiggest)
            {
                topIntegers.Add(element);
            }
        }
        topIntegers.Add(array[array.Length - 1]);

        Console.WriteLine(string.Join(" ", topIntegers));
    }
}

