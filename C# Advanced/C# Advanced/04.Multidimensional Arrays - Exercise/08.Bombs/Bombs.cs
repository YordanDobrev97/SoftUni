using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Bombs
{
    public class Bombs
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] values = Console.ReadLine().
                    Split()
                   .Select(int.Parse)
                   .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int[] indexesBombs = Console.ReadLine().Split(new[] { ' ', ','}, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < indexesBombs.Length; i+=2)
            {
                int row = indexesBombs[i];
                int col = indexesBombs[i + 1];

                int value = matrix[row, col];
                matrix[row, col] -= value;

                //left
                if (IsRange(matrix, row, col - 1) && matrix[row, col - 1] > 0)
                {                    
                    matrix[row, col - 1] -= value;
                }

                //right
                if (IsRange(matrix, row, col + 1) && matrix[row, col + 1] > 0)
                {
                    matrix[row, col + 1] -= value;
                }

                //up
                if (IsRange(matrix, row - 1, col) && matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= value;
                }

                //up left
                if (IsRange(matrix, row - 1, col - 1) && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= value;
                }

                //up right
                if (IsRange(matrix, row - 1, col + 1) && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= value;
                }

                //down middle
                if (IsRange(matrix, row + 1, col) && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= value;
                }

                //down left
                if (IsRange(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= value;
                }

                //down right
                if (IsRange(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= value;
                }

            }

            List<int> aliveCells = GetAliveCountCells(matrix);
            Console.WriteLine($"Alive cells: {aliveCells.Count}");
            Console.WriteLine($"Sum: {aliveCells.Sum()}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }

        private static List<int> GetAliveCountCells(int[,] matrix)
        {
            List<int> cells = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] > 0)
                    {
                        cells.Add(matrix[row, col]);
                    }
                }
            }

            return cells;
        }

        private static bool IsRange(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                                && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
