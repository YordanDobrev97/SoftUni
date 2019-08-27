using System;
using System.Linq;

namespace _05.SnakeMoves
{
    public class SnakeMoves
    {
        public static void PrintMatrix(char[,] matrix)
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
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizeMatrix[0];
            int column = sizeMatrix[1];

            char[,] matrix = new char[rows, column];
            string snake = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < column; col++)
                {
                    if (index > snake.Length - 1)
                    {
                        index = 0;
                    }

                    char symbol = snake[index];
                    matrix[row, col] = symbol;
                    index++;
                }
            }

            PrintMatrix(matrix);
        }
    }
}
