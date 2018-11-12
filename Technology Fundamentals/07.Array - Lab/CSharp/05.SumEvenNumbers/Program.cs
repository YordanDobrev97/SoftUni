using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int evenSum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int element = numbers[i];

            if (element % 2 == 0)
            {
                evenSum += element;
            }
        }
        Console.WriteLine(evenSum);
    }
}

