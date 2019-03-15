using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            bool hasEqualNumbers = false;
            do
            {
                hasEqualNumbers = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    double currentNumber = numbers[i];
                    double nextNumber = numbers[i + 1];

                    double sum = currentNumber + nextNumber;
                    if (currentNumber == nextNumber)
                    {
                        numbers.RemoveAt(i + 1);
                        numbers[i] = sum;
                        hasEqualNumbers = true;
                    }
                }

            } while (hasEqualNumbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
