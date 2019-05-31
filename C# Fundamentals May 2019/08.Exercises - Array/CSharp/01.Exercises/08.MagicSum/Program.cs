using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                int nextNumber = numbers[j];

                int sumNumbers = number + nextNumber;

                if (sumNumbers == sum)
                {
                    Console.WriteLine($"{number} {nextNumber}");
                }
            }
        }
    }
}

