using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeashellTreasure
{
    public class SeashellTreasure
    {
        static int stolenSeashells;

        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] values = Console.ReadLine().Split().
                    Select(c => char.Parse(c))
                    .ToArray();

                matrix[row] = values;
            }

            char emptySymbol = '-';
            List<char> collectedSeashells = new List<char>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "Sunset")
                {
                    break;
                }

                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if (command == "Collect")
                {
                    if (IsRange(row, col, matrix))
                    {
                        collectedSeashells.Add(matrix[row][col]);
                        matrix[row][col] = emptySymbol; 
                    }
                }
                else if (command == "Steal")
                {
                    string direction = input[3];

                    if (IsRange(row, col, matrix))
                    {
                        switch (direction)
                        {
                            case "up": Up(row,col, matrix); break;
                            case "down": Down(row,col, matrix); break;
                            case "left": Left(col,row, matrix); break;
                            case "right": Right(col,row, matrix); break;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
            Console.WriteLine($"Collected seashells: {collectedSeashells.Count} -> {string.Join(", ", collectedSeashells)}");
            Console.WriteLine($"Stolen seashells: {stolenSeashells}");
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }

                Console.WriteLine();
            }
        }

        private static void Right(int col, int row, char[][] matrix)
        {
            int length = Math.Min(col + 3, matrix[row].Length);

            for (int nextCol = col; nextCol <= length; nextCol++)
            {
                if (nextCol >= matrix[row].Length)
                {
                    break;
                }

                if (matrix[row][nextCol] != '-')
                {
                    matrix[row][nextCol] = '-';
                    stolenSeashells++;
                }
            }
        }

        private static void Left(int col, int row,  char[][] matrix)
        {
            int length = col - 3;
            for (int prevCol = col - 1; prevCol >= length; prevCol--)
            {
                if (matrix[prevCol][row] != '-')
                {
                    matrix[prevCol][row] = '-';
                    stolenSeashells++;
                }
            }
        }

        private static void Down(int row, int col, char[][] matrix)
        {
            int length = Math.Min(row + 3, matrix.GetLength(0));

            for (int nextRow = row + 1; nextRow <=length; nextRow++)
            {
                if (matrix[nextRow][col] != '-')
                {
                    matrix[nextRow][col] = '-';
                    stolenSeashells++;
                }
            }
        }

        private static void Up(int row,int col, char[][] matrix)
        {
            for (int prevRow = row - 1; prevRow >= row - 3; prevRow--)
            {
                if (matrix[prevRow][col] != '-')
                {
                    matrix[prevRow][col] = '-';
                    stolenSeashells++;
                }
            }
        }

        private static bool IsRange(int row, int col, char[][] matrix)
        {
            return row <= matrix.GetLength(0) - 1 && col <= matrix[row].Length - 1;
        }
    }
}
