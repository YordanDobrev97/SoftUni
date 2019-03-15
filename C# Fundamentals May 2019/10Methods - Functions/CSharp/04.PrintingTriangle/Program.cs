using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            PrintTriangle(size);

        }

        private static void PrintTriangle(int size)
        {
            PrintFirstPart(size);
            PrintSecondPart(size);
        }

        private static void PrintSecondPart(int size)
        {
            int count = size - 1;
            for (int i = 1; i <= size - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write($"{j} ");
                }
                count--;
                Console.WriteLine();
            }
        }

        private static void PrintFirstPart(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }
    }
}
