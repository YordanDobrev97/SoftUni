using System;

namespace _12.Number_Table
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <=n; row++)
            {
                for (int col = row; col <=n; col++)
                {
                    Console.Write($"{col} ");
                }

                for (int i = n - 1; i > n - row; i--)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
