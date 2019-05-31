using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int number = numbers[i];
            bool isBiggestAll = false;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                int next = numbers[j];

                if (number > next)
                {
                    isBiggestAll = true;
                }
                else
                {
                    isBiggestAll = false;
                    break;
                }
            }

            if (isBiggestAll)
            {
                Console.Write($"{number} ");
            }
        }

        Console.WriteLine(numbers[numbers.Length - 1]);
    }
}

