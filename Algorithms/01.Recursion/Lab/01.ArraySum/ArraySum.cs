using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.ArraySum
{
    class ArraySum
    {
        static int[] outputArray;
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4 };
            //int k = 2;
            //outputArray = new int[k];

            //int startIndex = 0;
            //AllPossibleCombinations(array, k, startIndex, 0);
            Console.WriteLine("Enter your numbers: ");
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = GetSumArray(arr, 0);
            Console.WriteLine($"Sum of array is: {sum}");

        }

        public static int GetSumArray(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + GetSumArray(array, index + 1);
        }

        private static void AllPossibleCombinations(int[] originalArray,
            int k, int index, int start)
        {
            if (index == outputArray.Length)
            {
                Print(outputArray);
            }
            else
            {
                for (int i = start; i <= originalArray.Length - 1
                    && originalArray.Length - 1 - i + 1 >= k - index; i++)
                {
                    outputArray[start] = originalArray[i];
                    AllPossibleCombinations(originalArray,
                        k, index + 1, start + 1);
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

    }
}
