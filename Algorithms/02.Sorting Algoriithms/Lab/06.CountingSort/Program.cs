using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10,9,8,2,1,10,9,8,4};

            int[] sorted = CountingSort(numbers);

            Console.WriteLine(string.Join(" ", sorted)); // 1 2 4 8 9 10
        }

        public static int[] CountingSort(int[] numbers)
        {
            int max = numbers.Max();
            int min = numbers.Min();

            int[] counting = new int[max - min + 1];

            int[] indexes = new int[max - min + 1];
            int index = 0;

            for (int i = min; i <= max; i++)
            {
                indexes[index] = i;
                index++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int indexOfCurrentNumber = Array.IndexOf(indexes, currentNumber);
                counting[indexOfCurrentNumber]++;
            }

            int[] sumCount = new int[max - min + 1];
            sumCount[0] = counting[0];

            for (int i = 1; i < sumCount.Length; i++)
            {
                int prevValue = sumCount[i - 1];
                int curentValueOfCounting = counting[i];
                int sum = prevValue + curentValueOfCounting;
                sumCount[i] = sum;
            }

            int[] position = new int[numbers.Length];
            int[] sortedInput = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int indexOfCurrentNumber = Array.IndexOf(indexes, currentNumber);
                int indexForSortedInput = sumCount[indexOfCurrentNumber];
                sortedInput[indexForSortedInput - 1] = currentNumber;
            }

            return sortedInput.Where(x => x != 0).ToArray();
        }
    }
}
