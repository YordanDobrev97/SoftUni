using System;
using System.Linq;

namespace P03_JediGalaxy
{
    public class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = dimestions[0];
            int col = dimestions[1];
            int[,] matrix = IntilizateMatrix(row, col);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoS = command.Split(new string[] { " " }, 
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evil = Console.ReadLine().
                    Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToArray();
                int evilRow = evil[0];
                int evilCol = evil[1];

                while (evilRow >= 0 && evilCol >= 0)
                {
                    bool isRange = evilRow >= 0 && evilRow < matrix.GetLength(0) && evilCol >= 0 && evilCol < matrix.GetLength(1);
                    if (isRange)
                    {
                        matrix[evilRow, evilCol] = 0;
                    }
                    evilRow--;
                    evilCol--;
                }

                int ivoRow = ivoS[0];
                int ivoCol = ivoS[1];

                while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
                {
                    if (IsRange(matrix, ivoRow, ivoCol))
                    {
                        sum += matrix[ivoRow, ivoCol];
                    }

                    ivoCol++;
                    ivoRow--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static bool IsRange(int[,] matrix, int ivoRow, int ivoCol)
        {
            return ivoRow >= 0 && ivoRow < matrix.GetLength(0) && ivoCol >= 0 && ivoCol < matrix.GetLength(1);
        }

        private static int[,] IntilizateMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];

            int value = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            return matrix;
        }
    }
}
