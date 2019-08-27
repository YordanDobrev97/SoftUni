using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    public class MatrixShuffling
    {
        public static void Main()
        {
            int[] valuesInput = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int rows = valuesInput[0];
            int column = valuesInput[1];

            string[,] matrix = new string[rows, column];

            for (int row = 0; row < rows; row++)
            {
                string[] values = Console.ReadLine().Split(" ", 
                    StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < column; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            string line = Console.ReadLine();

            while (line != "END")
            {
                if (!line.Contains("swap"))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string[] elements = line.Split();
                    int row1 = int.Parse(elements[1]);
                    int col1 = int.Parse(elements[2]);
                    int row2 = int.Parse(elements[3]);
                    int col2 = int.Parse(elements[4]);

                    if (IsRange(row1,col1,row2, col2, matrix))
                    {
                        //swap
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

                line = Console.ReadLine();
            }
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsRange(int row1, int col1, int row2, int col2, string[,] matrix)
        {
            if (row1 > matrix.GetLength(0) - 1 
                || col1 > matrix.GetLength(1) - 1 
                || row2 > matrix.GetLength(0) - 1
                || col2 > matrix.GetLength(1) - 1
                || row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0)
            {
                return false;
            }

            return true;
        }
    }
}
