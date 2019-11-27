using System;
using System.Linq;

namespace _01.ReverseArray
{
    public class ReverseArray
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            ReverseArr(array, 0);
            Console.WriteLine();
        }
        static void ReverseArr(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                Console.Write($"{array[index]} ");
                return;
            }

            ReverseArr(array, index + 1);
            Console.Write($"{array[index]} ");
        }
    }
}
