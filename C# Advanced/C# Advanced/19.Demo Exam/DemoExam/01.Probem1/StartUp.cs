using System;

public class StartUp
{
    static int countCarrots = 0;
    static int countPotatos = 0;
    static int countLettuce = 0;
    static int countHarmedVegetables = 0;

    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        var matrix = new string[rows][];

        IntilizateMatrix(matrix);

        while (true)
        {
            string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = line[0];
            if (command == "End")
            {
                break;
            }
            int row = int.Parse(line[1]);
            int col = int.Parse(line[2]);

            switch (command)
            {
                case "Harvest":
                    if (IsRange(row, col, matrix))
                    {
                        if (matrix[row][col] == "L")
                        {
                            countLettuce++;
                        }
                        else if (matrix[row][col] == "P")
                        {
                            countPotatos++;
                        }
                        else if (matrix[row][col] == "C")
                        {
                            countCarrots++;
                        }
                        matrix[row][col] = " ";
                    }
                    break;
                case "Mole":
                    string direction = line[3];
                    if (IsRange(row, col, matrix))
                    {
                        if (direction == "up")
                        {
                            MoveUp(matrix, row, col);
                        }
                        else if (direction == "down")
                        {
                            MoveDown(matrix, row, col);
                        }
                        else if (direction == "left")
                        {
                            MoveLeft(matrix, row, col);
                        }
                        else if (direction == "right")
                        {
                            MoveRight(matrix, row, col);
                        }

                    }
                    break;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(matrix[row][col] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Carrots: {countCarrots}");
        Console.WriteLine($"Potatoes: {countPotatos}");
        Console.WriteLine($"Lettuce: {countLettuce}");
        Console.WriteLine($"Harmed vegetables: {countHarmedVegetables}");
    }

    private static void MoveRight(string[][] matrix, int row, int col)
    {
        while (col <= matrix[row].Length - 1)
        {
            if (matrix[row][col] == "L" || matrix[row][col] == "P" || matrix[row][col] == "C")
            {
                countHarmedVegetables++;
            }
            matrix[row][col] = " ";
            col += 2;
        }
    }

    private static void MoveLeft(string[][] matrix, int row, int col)
    {
        while (col >= 0)
        {
            if (matrix[row][col] == "L" || matrix[row][col] == "P" || matrix[row][col] == "C")
            {
                countHarmedVegetables++;
            }
            matrix[row][col] = " ";
            col -= 2;
        }
    }

    private static void MoveDown(string[][] matrix, int row, int col)
    {
        while (row <= matrix.GetLength(0) - 1)
        {
            if (matrix[row][col] == "L" || matrix[row][col] == "P" || matrix[row][col] == "C")
            {
                countHarmedVegetables++;
            }
            matrix[row][col] = " ";
            row += 2;
        }
    }

    private static void MoveUp(string[][] matrix, int row, int col)
    {
        while (row >= 0)
        {
            if (matrix[row][col] == "L" || matrix[row][col] == "P" || matrix[row][col] == "C")
            {
                countHarmedVegetables++;
            }
            matrix[row][col] = " ";
            row -= 2;
        }
    }

    private static bool IsRange(int row, int col, string[][] matrix)
    {
        return row >= 0 && row <= matrix.GetLength(0) - 1 && col >= 0 && col <= matrix[row].Length - 1;
    }

    private static void IntilizateMatrix(string[][] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            matrix[row] = new string[line.Length];
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] = line[col];
            }
        }
    }
}
