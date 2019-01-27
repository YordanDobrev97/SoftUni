using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    public class SumMatrixColumns
    {
        public static void Main()
        {
            int[] matrixData = Console.ReadLine()
               .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int rows = matrixData[0];
            int cols = matrixData[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colsData = Console.ReadLine()
                    .Split(new[] {' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colsData[col];
                }
            }


            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
