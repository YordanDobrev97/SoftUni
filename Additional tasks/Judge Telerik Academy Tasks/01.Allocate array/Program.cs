using System;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main()
        {
            int sizeArray = int.Parse(Console.ReadLine());

            int[] values = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                values[i] = i * 5;
            }

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}
