using System;

class Program
{
    static void Main()
    {
        int arrayCount = int.Parse(Console.ReadLine());

        string[,] matrix = new string[arrayCount, 2];
        for (int i = 0; i < arrayCount; i++)
        {
            string[] values = Console.ReadLine()
                .Split(' ');

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[i, col] = values[col];
            }
        }

        string[] firstArray = new string[arrayCount];

        int colum = 0;

        for (int i = 0; i < arrayCount; i++)
        {
            string value = matrix[i, colum];
            firstArray[i] = value;
            if ((i + 1) % 2 == 0)
            {
                colum--;
            }
            else
            {
                colum++;
            }
        }

        Console.WriteLine(string.Join(" ", firstArray));

        string[] secondArray = new string[arrayCount];

        int index = 0;
        int column = matrix.GetLength(1) - 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string value = matrix[row, column];
            secondArray[index] = value;
            index++;

            if ((row + 1) % 2 == 0)
            {
                column++;
            }
            else
            {
                column--;
            }
        }
        Console.WriteLine(string.Join(" ", secondArray));
    }
}

