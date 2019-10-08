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
            //Throw exception, don't know
            int[] sizeMatrix = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizeMatrix[0];
            int column = sizeMatrix[1];

            char[,] matrix = new char[rows, column];
            string snake = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < column; col++)
                    {
                        matrix[row, col] = snake[index++];

                        if (index == snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = column; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];

                        if (index == snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }
    }
}
