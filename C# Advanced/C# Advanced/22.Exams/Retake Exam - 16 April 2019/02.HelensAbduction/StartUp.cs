using System;

public class StartUp
{
    static int parisRow;
    static int parisCol;
    static int energy;
    static bool isWin = false;

    public static void Main()
    {
        energy = int.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        char[,] matrix = new char[rows, rows];

        IntilizateMatrix(matrix);

        bool isDead = false;
        while (true)
        {
            string[] directionParams = Console.ReadLine().Split();
            string direction = directionParams[0];
            int row = int.Parse(directionParams[1]);
            int column = int.Parse(directionParams[2]);

            MoveSpartan(matrix, row, column);
            energy -= 1;
            switch (direction)
            {
                case "up":
                    if (!MoveUp(matrix))
                    {
                        isDead = true;
                        break;
                    }
                    break;
                case "down":
                    if (!MoveDown(matrix))
                    {
                        isDead = true;
                        break;
                    }
                    break;
                case "left":
                    if (!MoveLeft(matrix))
                    {
                        isDead = true;
                        break;
                    }
                    break;
                case "right":
                    if (!MoveRight(matrix))
                    {
                        isDead = true;
                        break;
                    }
                    break;
            }

            if (isDead)
            {
                matrix[parisRow, parisCol] = 'X';
                break;
            }
            else if (isWin)
            {
                matrix[parisRow, parisCol] = '-';
                break;
            }
        }

        if (isDead)
        {
            Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
        }
        else
        {
            Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row,col]}");
            }
            Console.WriteLine();
        }
    }

    private static bool MoveRight(char[,] matrix)
    {
        bool isMoveSuccess = true;
        if (parisCol + 1 <= matrix.GetLength(1) - 1)
        {
            matrix[parisRow, parisCol] = '-';
            parisCol++;
            if (matrix[parisRow, parisCol] == 'S')
            {
                energy -= 2;
            }
            else if (matrix[parisRow, parisCol] == 'H')
            {
                isWin = true;
                return isWin;
            }

            if (energy == 0)
            {
                isMoveSuccess = false;
            }
            else
            {
                matrix[parisRow, parisCol] = 'P';
            }
        }
        return isMoveSuccess;
    }

    private static bool MoveLeft(char[,] matrix)
    {
        bool isMoveSuccess = true;
        if (parisCol - 1 >= 0)
        {
            matrix[parisRow, parisCol] = '-';
            parisCol--;
            if (matrix[parisRow, parisCol] == 'S')
            {
                energy -= 2;
            }
            else if (matrix[parisRow, parisCol] == 'H')
            {
                isWin = true;
                return isWin;
            }

            if (energy == 0)
            {
                isMoveSuccess = false;
            }
            else
            {
                matrix[parisRow, parisCol] = 'P';
            }
        }
        return isMoveSuccess;
    }

    private static bool MoveDown(char[,] matrix)
    {
        bool isMoveSuccess = true;
        if (parisRow + 1 <= matrix.GetLength(0) - 1)
        {
            matrix[parisRow, parisCol] = '-';
            parisRow++;
            if (matrix[parisRow, parisCol] == 'S')
            {
                energy -= 2;
            }
            else if (matrix[parisRow, parisCol] == 'H')
            {
                isWin = true;
                return isWin;
            }

            if (energy == 0)
            {
                isMoveSuccess = false;
            }
            else
            {
                matrix[parisRow, parisCol] = 'P';
            }
        }
        return isMoveSuccess;
    }

    private static bool MoveUp(char[,] matrix)
    {
        bool isSuccessMove = true;
        if (parisRow - 1 >= 0)
        {
            matrix[parisRow, parisCol] = '-';
            parisRow--;
            if (matrix[parisRow, parisCol] == 'S')
            {
                energy -= 2;
            }
            else if (matrix[parisRow, parisCol] == 'H')
            {
                isWin = true;
                return isWin;
            }

            if (energy == 0)
            {
                isSuccessMove = false;
            }
            else
            {
                matrix[parisRow, parisCol] = 'P';
            }
        }

        return isSuccessMove;
    }

    private static void MoveSpartan(char[,] matrix, int row, int col)
    {
        if (IsRange(matrix, row, col))
        {
            matrix[row, col] = 'S';
        }
    }

    private static bool IsRange(char[,] matrix, int row, int col)
    {
        return row >= 0 && row <= matrix.GetLength(0) - 1 && col >=0 && col <= matrix.GetLength(1);
    }

    private static void IntilizateMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = line[col];

                if (matrix[row,col] == 'P')
                {
                    parisRow = row;
                    parisCol = col;
                }
            }
        }
    }
}