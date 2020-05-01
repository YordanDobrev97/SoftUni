using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CountingSort
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 3, 4, 2, 3, 2, 4};

            int min = 0;
            int max = 10;
            int[] sorted = Counting(numbers, min, max);

            Console.WriteLine(string.Join(" ", sorted));
        }

        public static int[] Counting(int[] numbers, int min, int max)
        {


            return null;
        }
    }
}
