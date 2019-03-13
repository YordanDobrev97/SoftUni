using System;
using System.Collections.Generic;

namespace _07.FindAllPathsInLabyrinth
{
    class FindAllPathsInLabyrinth
    {
        private static List<string> path = new List<string>();

        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            char[,] labyrinth = new char[row, col];

            for (int rows = 0; rows < row; rows++)
            {
                string matrixInput = Console.ReadLine();
                for (int cols = 0; cols < col; cols++)
                {
                    char symbol = matrixInput[cols];
                    labyrinth[rows, cols] = symbol;
                }
            }

            Solve(labyrinth, 0, 0, "");
        }

        private static void Solve(char[,] labyrinth,
            int row, int col, string currentPath)
        {
            if (OutsideBorder(row, col, labyrinth))
            {
                return;
            }

            path.Add(currentPath);

            if (FoundExit(row, col, labyrinth))
            {
                PrintPath();
            }
            else
            {
                if (PlaceFree(labyrinth, row, col))
                {
                    MarkPath(row, col, labyrinth);
                    Solve(labyrinth, row, col + 1, "R"); // right
                    Solve(labyrinth, row + 1, col, "D"); // down
                    Solve(labyrinth, row, col - 1, "L"); // left
                    Solve(labyrinth, row - 1, col, "U"); // up
                    UnmarkPath(row, col, labyrinth);
                }
            }
            path.RemoveAt(path.Count - 1);
        }

        private static bool OutsideBorder(int row, int col, char[,] matrix)
        {
            return row < 0 
                || row >= matrix.GetLength(0)
                || col >= matrix.GetLength(1)
                || col < 0;
        }

        private static void UnmarkPath(int row, int col, char[,] labyrinth)
        {
            labyrinth[row, col] = '-';
        }

        private static void MarkPath(int row, int col, char[,] labyrinth)
        {
            labyrinth[row, col] = 'v';//visited
        }

        private static bool PlaceFree(char[,] matrix, int row, int col)
        {
            if (matrix[row, col] == '-')
            {
                return true;
            }

            return false;
        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join("", path));
        }

        private static bool FoundExit(int row, int col, char[,] matrix)
        {
            return matrix[row, col] == 'e';
        }
    }
}
