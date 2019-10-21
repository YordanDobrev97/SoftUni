using System;

public class StartUp
{
    static int firstPlayerPositionX;
    static int firstPlayerPositionY;
    static int secondPlayerPositionX;
    static int secondPlayerPositionY;

    static void Main()
    {
        int sizeMatrix = int.Parse(Console.ReadLine());
        char[,] matrix = new char[sizeMatrix, sizeMatrix];

        IntilizateMatrix(matrix);

        while (true)
        {
            string[] command = Console.ReadLine().Split();
            string directionFirstPlayer = command[0];
            string directionSecondPlayer = command[1];

            bool isDeadFirstPlayer =  MoveFirstPlayerSuccess(directionFirstPlayer, matrix);
            if (isDeadFirstPlayer)
            {
                break;
            }

            bool isDeadSecondPlayer = MoveSecondPlayerSuccess(directionSecondPlayer, matrix);

            if (isDeadSecondPlayer)
            {
                break;
            }
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

    private static bool MoveSecondPlayerSuccess(string directionSecondPlayer, char[,] matrix)
    {
        switch (directionSecondPlayer)
        {
            case "up":
                if (secondPlayerPositionX - 1 < 0)
                {
                    secondPlayerPositionX = matrix.GetLength(0) - 1;
                }
                else
                {
                    if (matrix[secondPlayerPositionX - 1, secondPlayerPositionY] == 'f')
                    {
                        matrix[secondPlayerPositionX - 1, secondPlayerPositionY] = 'x';
                        return true;
                    }
                    secondPlayerPositionX--;
                }
                break;
            case "down":
                if (secondPlayerPositionX + 1 > matrix.GetLength(0) - 1)
                {
                    secondPlayerPositionX = 0;
                }
                else
                {
                    if (matrix[secondPlayerPositionX + 1, secondPlayerPositionY] == 'f')
                    {
                        matrix[secondPlayerPositionX + 1, secondPlayerPositionY] = 'x';
                        return true;
                    }

                    secondPlayerPositionX++;
                }
                break;
            case "left":
                if (secondPlayerPositionY - 1 > 0)
                {
                    secondPlayerPositionY = matrix.GetLength(1) - 1;
                }
                else
                {
                    if (matrix[secondPlayerPositionX, secondPlayerPositionY - 1] == 'f')
                    {
                        matrix[secondPlayerPositionX, secondPlayerPositionY - 1] = 'x';
                        return true;
                    }

                    secondPlayerPositionY--;
                }
                break;
            case "right":
                if (secondPlayerPositionY + 1 >= matrix.GetLength(1))
                {
                    secondPlayerPositionY = 0;
                }
                else
                {
                    if (matrix[secondPlayerPositionX, secondPlayerPositionY + 1] == 'f')
                    {
                        matrix[secondPlayerPositionX, secondPlayerPositionY + 1] = 'x';
                        return true;
                    }

                    secondPlayerPositionY++;
                }
                break;
        }

        matrix[secondPlayerPositionX, secondPlayerPositionY] = 's';
        return false;
    }

    private static bool MoveFirstPlayerSuccess(string directionFirstPlayer, char[,] matrix)
    {
        switch (directionFirstPlayer)
        {
            case "up":
                if (firstPlayerPositionX - 1 < 0)
                {
                    firstPlayerPositionX = matrix.GetLength(0) - 1;
                }
                else
                {
                    if (matrix[firstPlayerPositionX - 1, firstPlayerPositionY] == 's')
                    {
                        matrix[firstPlayerPositionX, firstPlayerPositionY] = 'x';
                        return true;
                    }

                    firstPlayerPositionX--;
                }
                break;
            case "down":
                if (firstPlayerPositionX + 1 > matrix.GetLength(0) - 1)
                {
                    firstPlayerPositionX = 0;
                }
                else
                {
                    if (matrix[firstPlayerPositionX + 1, firstPlayerPositionY] == 's')
                    {
                        matrix[firstPlayerPositionX + 1, firstPlayerPositionY] = 'x';
                        return true;
                    }

                    firstPlayerPositionX++;
                }
                break;
            case "left":
                if (firstPlayerPositionY - 1 < 0)
                {
                    firstPlayerPositionY = matrix.GetLength(1) - 1;
                }
                else
                {
                    if (matrix[firstPlayerPositionX, firstPlayerPositionY - 1] == 's')
                    {
                        matrix[firstPlayerPositionX, firstPlayerPositionY - 1] = 'x';
                        return true;
                    }

                    firstPlayerPositionY--;
                }
                break;
            case "right":
                if (firstPlayerPositionY + 1 > matrix.GetLength(1) - 1)
                {
                    firstPlayerPositionY = 0;
                }
                else
                {
                    if (matrix[firstPlayerPositionX ,firstPlayerPositionY + 1] == 's')
                    {
                        matrix[firstPlayerPositionX, firstPlayerPositionY + 1] = 'x';
                        return true;
                    }

                    firstPlayerPositionY++;
                }
                break;
        }

        matrix[firstPlayerPositionX, firstPlayerPositionY] = 'f';
        return false;
    }

    private static void IntilizateMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = line[col];
                if (matrix[row, col] == 'f')
                {
                    firstPlayerPositionX = row;
                    firstPlayerPositionY = col;
                }
                else if (matrix[row, col] == 's')
                {
                    secondPlayerPositionX = row;
                    secondPlayerPositionY = col;
                }
            }
        }
    }
}
