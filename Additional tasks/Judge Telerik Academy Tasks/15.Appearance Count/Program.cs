using System;
using System.Linq;

namespace _15.Appearance_Count
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            array = input;

            int x = int.Parse(Console.ReadLine());
            int countAppearance = CountAppearance(array, x);
            Console.WriteLine(countAppearance);
        }
        static int CountAppearance(int[] array, int x)
        {
            int counter = 0;

            foreach (var num in array)
            {
                if (num == x)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
