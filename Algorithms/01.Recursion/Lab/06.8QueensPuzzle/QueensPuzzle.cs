using System;
using System.Collections.Generic;

namespace _06._8QueensPuzzle
{
    public class QueensPuzzle
    {
        private static int sizeMatrix = 8;

        private static HashSet<int> forbiddenRows = new HashSet<int>();
        private static HashSet<int> forbiddenColums = new HashSet<int>();
        private static HashSet<int> forbiddenLeft = new HashSet<int>();
        private static HashSet<int> forbiddenRight = new HashSet<int>();

        static int[,] matrix;

        public static void Main()
        {
            matrix = new int[sizeMatrix, sizeMatrix];
            Solve(0);
        }

        public static void Solve(int index)
        {
            if (FoundSolution(index))
            {
                PrintSolution();
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < sizeMatrix; i++)
                {
                    if (HasRespectiveSolution(index, i))
                    {
                        MarkSolution(index, i);
                        Solve(index + 1);
                        UnmarkSolution(index, i);
                    }
                }
            }
        }

        private static void UnmarkSolution(int row, int col)
        {
            matrix[row, col] = 0;

            forbiddenRows.Remove(row);
            forbiddenColums.Remove(col);
            forbiddenLeft.Remove(col - row);
            forbiddenRight.Remove(row + col);
        }

        private static void MarkSolution(int row, int col)
        {
            matrix[row, col] = 1;

            forbiddenRows.Add(row);
            forbiddenColums.Add(col);
            forbiddenLeft.Add(col - row);
            forbiddenRight.Add(row + col);
        }

        private static bool HasRespectiveSolution(int row, int col)
        {
            bool isRespective = false;

            if (forbiddenRows.Contains(row)
               || forbiddenColums.Contains(col)
               || forbiddenLeft.Contains(col - row)
               || forbiddenRight.Contains(row + col))
            {
                isRespective = true;
            }

            return !isRespective;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] == 1 ? "*" : "-");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        private static bool FoundSolution(int index)
        {
            return index == sizeMatrix;
        }
    }
}
