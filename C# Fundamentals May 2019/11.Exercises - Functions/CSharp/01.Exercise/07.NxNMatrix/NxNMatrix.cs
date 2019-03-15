using System;

namespace _07.NxNMatrix
{
    public class NxNMatrix
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[size, size];

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    Console.Write($"{size} ");
                }
                Console.WriteLine();
            }

            //for (int rows = 0; rows < size; rows++)
            //{
            //    for (int cols = 0; cols < size; cols++)
            //    {
            //        Console.Write($"{matrix[rows, cols]} ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
