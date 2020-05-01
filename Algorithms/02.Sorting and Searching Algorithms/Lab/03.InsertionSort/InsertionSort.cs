using System;
using System.Linq;

namespace _03.InsertionSort
{
    class InsertionSort
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                int current = numbers[i]; 
                int prev = i - 1;
                int index = i;

                while (prev >= 0 && numbers[prev] > current)
                {
                    numbers[index] = numbers[prev];
                    numbers[prev] = current;
                    prev--;
                    index--;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}