using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.ArraySum
{
    class ArraySum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = GetSumArray(arr, 0);
            Console.WriteLine($"{sum}");

        }

        public static int GetSumArray(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + GetSumArray(array, index + 1);
        }
    }
}
