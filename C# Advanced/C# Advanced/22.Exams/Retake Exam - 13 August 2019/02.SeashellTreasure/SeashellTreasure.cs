using System;
using System.Collections.Generic;
using System.Linq;

public class SeashellTreasure
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        char[][] matrix = new char[rows][];

        IntilizateMatrix(matrix);

        while (true)
        {
            string[] line = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries);

            string command = line[0];
            int row = int.Parse(line[1]);
            int col = int.Parse(line[2]);

            switch (command)
            {
                case "Steal":
                    string direction = line[3];
                    if (direction == "up")
                    {
                        for (int i = 0; i < row - 3; i++)
                        {

                        }
                    }

                    break;
            }
        }
    }

    private static void IntilizateMatrix(char[][] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string line = Console.ReadLine();
            matrix[row] = new char[line.Length];
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] = line[col];
            }
        }
    }
}

