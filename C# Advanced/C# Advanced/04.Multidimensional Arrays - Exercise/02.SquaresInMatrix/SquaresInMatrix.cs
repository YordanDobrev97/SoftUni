using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            int[] sizeValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizeValues[0];
            int column = sizeValues[1];

            char[,] matrix = new char[rows, column];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] values = Console.ReadLine().ToCharArray().Where(x => x!= ' ').ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < column - 1; col++)
                {
                    char currentLeftUpValue = matrix[row, col];
                    char currentRightUpValue = matrix[row, col + 1];
                    char currentLeftDownValue = matrix[row + 1, col];
                    char currentRightDownValue = matrix[row + 1, col + 1];

                    if (currentLeftUpValue == currentRightUpValue 
                        && currentLeftUpValue == currentLeftDownValue
                        && currentLeftUpValue == currentRightDownValue)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
