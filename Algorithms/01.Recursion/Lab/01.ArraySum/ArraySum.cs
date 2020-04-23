using System;
using System.Linq;
namespace SumOfArray
{
    public class ArraySum
    {
        static void Main()
        {
            int[] arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int index = 0;

            int sum = GetSumArray(arrayInput, index);
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
