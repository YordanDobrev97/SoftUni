using System;

namespace _07.PascalTriangle
{
    public class PascalTriangle
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            long[][] triangle = new long[sizeMatrix][];

            for (int row = 0; row < sizeMatrix; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;

                for (int col = 1; col < triangle[row].Length - 1; col++)
                {
                    long leftUp = triangle[row - 1][col - 1];
                    long up = triangle[row - 1][col];

                    long sum = leftUp + up;

                    triangle[row][col] = sum;
                }

                triangle[row][triangle[row].Length - 1] = 1;
            }

            foreach (var values in triangle)
            {
                Console.WriteLine(string.Join(" ", values));
            }
        }
    }
}
