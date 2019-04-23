using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            int endIndex = 0;

            bool foundOccurrences = false;
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] == number)
                {
                    foundOccurrences = true;
                    endIndex = i;
                    break;
                }
            }

            if (!foundOccurrences)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = 0;
                for (int i = 0; i < endIndex; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
