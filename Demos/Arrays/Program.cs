using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];

            for (int i = 1; i <=array.Length; i++)
            {
                array[i - 1] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
