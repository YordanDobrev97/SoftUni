using System;
using System.Linq;
namespace _05.SquareWithMaximumSum
{
    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            int[] dataMatrix = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dataMatrix[0];
            int cols = dataMatrix[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] dataColumn = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = dataColumn[col];
                }
            }

            int sum = 0;
            int positionRow = 0;
            int positionCol = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        positionRow = row;
                        positionCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[positionRow, positionCol]} {matrix[positionRow, positionCol + 1]}");
            Console.WriteLine($"{matrix[positionRow + 1, positionCol]} {matrix[positionRow + 1, positionCol + 1]}");
            Console.WriteLine(sum);
        }
    }
}
