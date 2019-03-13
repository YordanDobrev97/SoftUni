using System;
using System.Linq;

namespace _02.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            SortingSelection(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void SortingSelection(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int min = currentNumber;
                int indexMin = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];

                    if (nextNumber < min)
                    {
                        min = nextNumber;
                        indexMin = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[indexMin];
                numbers[indexMin] = temp;
            }
        }
    }
}
