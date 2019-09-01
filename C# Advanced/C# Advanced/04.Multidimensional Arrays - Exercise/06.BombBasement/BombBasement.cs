using System;
using System.Linq;

namespace _06.BombBasement
{
    public class BombBasement
    {
        public static void Main()
        {
            //20/100
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizeMatrix[0];
            int column = sizeMatrix[1];
            int[,] matrix = new int[rows, column];

            int bombRow = bombParameters[0];
            int bombCol = bombParameters[1];
            int radius = bombParameters[2];

            for (int i = 0; i < bombRow; i++)
            {
                matrix[i, bombCol] = 1;
            }

            //up left
            for (int col = bombRow - 1; col <= radius - 1; col++)
            {
                matrix[bombRow - 1, bombCol - 1] = 1;
            }

            //up right
            int colBomb = bombCol + 1;
            for (int col = 0; col < radius - 1; col++)
            {
                matrix[bombRow - 1, colBomb] = 1;
                colBomb++;
            }

            matrix[bombRow, bombCol] = 1;

            //left
            for (int col = bombCol - bombRow; col <= radius; col++)
            {
                matrix[bombRow, col] = 1;
            }

            //right
            int targetCol = bombCol + 1;
            for (int col = 0; col < radius; col++)
            {
                matrix[bombRow, targetCol++] = 1;
            }

            int targetRow = bombRow + 1;
            for (int i = 0; i < radius; i++)
            {
                matrix[targetRow, bombCol] = 1;
                targetRow++;
            }

            //down left
            for (int col = 0; col < radius - 1; col++)
            {
                matrix[bombRow + 1, bombCol - 1] = 1;
            }

            matrix[bombRow + 1, bombCol] = 1;

            for (int col = 0; col < radius - 1; col++)
            {
                matrix[bombRow + 1, bombCol + 1] = 1;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        MoveUp(matrix, row, col);
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        private static void MoveUp(int[,] matrix, int row, int col)
        {
            while (row - 1 >= 0)
            {
                if (matrix[row - 1, col] != 1)
                {
                    matrix[row, col] = 0;
                    matrix[row - 1, col] = 1;
                }
                row--;
            }
        }
    }
}
