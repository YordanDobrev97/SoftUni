using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    public class PrimaryDiagonal
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            for (int row = 0; row < sizeMatrix; row++)
            {
                int[] colsData = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row, col] = colsData[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < sizeMatrix; row++)
            {
                int value = matrix[row, row];
                sum += value;
            }

            Console.WriteLine(sum);
        }
    }
}
