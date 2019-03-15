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

        int length = numbers.Length - 1;

        while (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                int currentElement = numbers[i];
                int nextElement = numbers[i + 1];

                int sum = currentElement + nextElement;
                numbers[i] = sum;
            }

            length--;
        }

        Console.WriteLine(numbers[0]);
    }
}

