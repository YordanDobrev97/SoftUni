using System;
using System.Linq;
namespace _07.Odd_or_Even_Product
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            int[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToArray();

            for (int i = 0; i < size; i++)
            {
                array[i] = inputNumbers[i];
            }

            long oddSum = 1;
            long evenSum = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum *= array[i];
                }
                else
                {
                    evenSum *= array[i];
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("yes {0}", oddSum);
            }
            else
            {
                Console.WriteLine("no {0} {1}", evenSum, oddSum);
            }
        }
    }
}
