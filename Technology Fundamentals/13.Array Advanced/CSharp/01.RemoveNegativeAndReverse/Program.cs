using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool hasNegatiaveNumber = false;

            do
            {
                hasNegatiaveNumber = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    int number = numbers[i];
                    if (number < 0)
                    {
                        hasNegatiaveNumber = true;
                        numbers.RemoveAt(i);
                    }
                }
            } while (hasNegatiaveNumber);

            if (numbers.Count > 0)
            {
                numbers.Reverse();

                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
