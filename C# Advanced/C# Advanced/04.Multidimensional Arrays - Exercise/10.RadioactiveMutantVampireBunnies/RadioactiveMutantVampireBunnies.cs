using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    public class RadioactiveMutantVampireBunnies
    {
        static int playerRowIndex = 0;
        static int playerColIndex = 0;
        static char[][] matrix;

        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizeMatrix[0];
            int column = sizeMatrix[1];

            matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                matrix[row] = new char[line.Length];
                for (int col = 0; col < column; col++)
                {
                    if (line[col] == 'P')
                    {
                        playerRowIndex = row;
                        playerColIndex = col;

                    }
                    matrix[row][col] = line[col];
                }
            }

            string direction = Console.ReadLine();

            int index = 0;
            while (index <= rows - 1)
            {
                char currentDirection = direction[index];

                int oldestRow = playerRowIndex;
                int oldestCol = playerColIndex;

                switch (currentDirection)
                {
                    case 'U':
                        playerRowIndex -= 1;
                        break;
                    case 'D':
                        playerRowIndex += 1;
                        break;
                    case 'L':
                        playerColIndex -= 1;
                        break;
                    case 'R':
                        playerColIndex += 1;
                        break;
                }

                if (IsOutRangePlayer())
                {
                    matrix[oldestRow][oldestCol] = '.';
                    MultiplyBunnies();
                    Exit("won");
                }

                if (IsHasBunny())
                {
                    MultiplyBunnies();
                    Exit("dead");
                }

                matrix[oldestRow][oldestCol] = '.';
                matrix[playerRowIndex][playerColIndex] = 'P';
                index++;

                MultiplyBunnies();
            }
        }

        private static void MultiplyBunnies()
        {
            List<int> indexesOfBunny = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        indexesOfBunny.Add(row);
                        indexesOfBunny.Add(col);
                    }
                }
            }

            for (int i = 0; i < indexesOfBunny.Count; i += 2)
            {
                int row = indexesOfBunny[i];
                int col = indexesOfBunny[i + 1];

                //up
                if (row - 1 >= 0)
                {
                    matrix[row - 1][col] = 'B';
                }

                //down
                if (row + 1 <= matrix.GetLength(0) - 1)
                {
                    matrix[row + 1][col] = 'B';
                }

                //left
                if (col - 1 >= 0)
                {
                    matrix[row][col - 1] = 'B';
                }

                //right
                if (col + 1 <= matrix[row].Length - 1)
                {
                    matrix[row][col + 1] = 'B';
                }
            }
        }

        private static bool IsOutRangePlayer()
        {
            if (playerRowIndex < 0)
            {
                playerRowIndex = 0;
                return true;
            }

            if (playerRowIndex >= matrix.GetLength(0))
            {
                playerRowIndex = matrix.GetLength(0) - 1;
                return true;
            }

            if (playerColIndex < 0)
            {
                playerColIndex = 0;
                return true;
            }

            if (playerColIndex >= matrix[playerRowIndex].Length)
            {
                playerColIndex = matrix[playerRowIndex].Length - 1;
                return true;
            }

            return false;
        }

        private static void Exit(string message)
        {
            PrintMatrix();
            Console.WriteLine($"{message}: {playerRowIndex} {playerColIndex}");
            Environment.Exit(0);
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]}");
                }
                Console.WriteLine();
            }
        }

        private static bool IsHasBunny()
        {
            return matrix[playerRowIndex][playerColIndex] == 'B';
        }
    }
}
