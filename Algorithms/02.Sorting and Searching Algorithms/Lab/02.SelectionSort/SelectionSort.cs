using System;
using System.Linq;

namespace _02.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int min = numbers[i];
                int indexMin = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        indexMin = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[indexMin];
                numbers[indexMin] = temp;
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}