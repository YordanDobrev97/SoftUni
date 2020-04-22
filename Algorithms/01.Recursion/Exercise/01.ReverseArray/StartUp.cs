using System;
using System.Linq;

namespace _01.ReverseArray
{
    public class StartUp
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            ReverseArray(array, 0);
            Console.WriteLine();
        }
        static void ReverseArray(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                Console.Write($"{array[index]} ");
                return;
            }

            ReverseArray(array, index + 1);
            Console.Write($"{array[index]} ");
        }
    }
}
