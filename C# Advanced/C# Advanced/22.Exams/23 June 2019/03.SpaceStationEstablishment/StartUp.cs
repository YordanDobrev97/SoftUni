using System;

public class StartUp
{
    static int positionPlayerX;
    static int positionPlayerY;
    static int positionFirstBlackHoleX;
    static int positionFirstBlackHoleY;
    static int positionSecondBlackHoleX;
    static int positionSecondBlackHoleY;

    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char[,] matrix = new char[size, size];

        IntilizateMatrix(matrix);

        bool isSuccess = true;
        int powerCollected = 0;

        while (true)
        {
            if (powerCollected == 50)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                Console.WriteLine($"Star power collected: {powerCollected}");
                break;
            }

            var command = Console.ReadLine();

            switch (command)
            {
                case "up":
                    if (OutGalaxyUp(positionPlayerX - 1))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        isSuccess = false;
                        break;
                    }
                    else if (HasBlackHole(positionPlayerX - 1, positionPlayerY, matrix))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX = positionSecondBlackHoleX;
                        positionPlayerY = positionSecondBlackHoleY;
                        RemoveBlackHoles(matrix);
                        MovePlayerLastBlackHole(matrix);
                    }
                    else if (HasStar(positionPlayerX - 1, positionPlayerY,matrix))
                    {
                        powerCollected += matrix[positionPlayerX - 1, positionPlayerY] - '0';
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX -= 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                    }
                    else
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX -= 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                        
                    }
                    break;
                case "down":
                    if (OutGalaxyDown(positionPlayerX + 1, matrix))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        isSuccess = false;
                        break;
                    }
                    else if (HasBlackHole(positionPlayerX + 1, positionPlayerY, matrix))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX = positionSecondBlackHoleX;
                        positionPlayerY = positionSecondBlackHoleY;
                        RemoveBlackHoles(matrix);
                        MovePlayerLastBlackHole(matrix);
                    }
                    else if (HasStar(positionPlayerX + 1, positionPlayerY, matrix))
                    {
                        powerCollected += matrix[positionPlayerX + 1, positionPlayerY] - '0';
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX += 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                    }
                    else
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX += 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                    }
                    break;
                case "left":
                    if (OutGalaxyLeft(positionPlayerY - 1))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        isSuccess = false;
                        break;
                    }
                    else if (HasBlackHole(positionPlayerX, positionPlayerY - 1, matrix))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX = positionSecondBlackHoleX;
                        positionPlayerY = positionSecondBlackHoleY;
                        RemoveBlackHoles(matrix);
                        MovePlayerLastBlackHole(matrix);
                    }
                    else if (HasStar(positionPlayerX, positionPlayerY - 1, matrix))
                    {
                        powerCollected += matrix[positionPlayerX, positionPlayerY - 1] - '0';
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerY -= 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                    }
                    else
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerY -= 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                    }
                    break;
                case "right":
                    if (OutGalaryRight(positionPlayerY + 1, matrix))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        isSuccess = false;
                        break;
                    }
                    else if (HasBlackHole(positionPlayerX, positionPlayerY + 1, matrix))
                    {
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerX = positionSecondBlackHoleX;
                        positionPlayerY = positionSecondBlackHoleY;
                        RemoveBlackHoles(matrix);
                        MovePlayerLastBlackHole(matrix);
                    }
                    else if (HasStar(positionPlayerX, positionPlayerY + 1, matrix))
                    {
                        powerCollected += matrix[positionPlayerX, positionPlayerY + 1] - '0';
                        matrix[positionPlayerX, positionPlayerY] = '-';
                        positionPlayerY += 1;
                        matrix[positionPlayerX, positionPlayerY] = 'S';
                    }
                    break;
            }

            if (!isSuccess)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
                Console.WriteLine($"Star power collected: {powerCollected}");
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

    private static bool OutGalaryRight(int playerY, char[,] matrix)
    {
        return playerY >= matrix.GetLength(1);
    }

    private static bool OutGalaxyLeft(int playerY)
    {
        return playerY < 0;
    }

    private static bool OutGalaxyDown(int positionPlayerX, char[,] matrix)
    {
        return positionPlayerX > matrix.GetLength(0);
    }

    private static bool HasStar(int playerX, int positionPlayerY, char[,] matrix)
    {
        if (char.IsDigit(matrix[playerX, positionPlayerY]))
        {
            return true;
        }

        return false;
    }

    private static void MovePlayerLastBlackHole(char[,] matrix)
    {
        matrix[positionSecondBlackHoleX, positionSecondBlackHoleY] = 'S';
    }

    private static void RemoveBlackHoles(char[,] matrix)
    {
        matrix[positionFirstBlackHoleX, positionFirstBlackHoleY] = '-';
        matrix[positionSecondBlackHoleX, positionSecondBlackHoleY] = '-';
    }

    private static bool HasBlackHole(int positionPlayerX, int positionPlayerY, char[,] matrix)
    {
        return matrix[positionPlayerX, positionPlayerY] == 'O';
    }

    private static bool OutGalaxyUp(int positionPlayerX)
    {
        return positionPlayerX < 0;
    }

    private static void IntilizateMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = line[col];
                if (line[col] == 'S')
                {
                    positionPlayerX = row;
                    positionPlayerY = col;
                }

                if (line[col] == 'O')
                {
                    if (positionFirstBlackHoleX == 0 && positionFirstBlackHoleY == 0)
                    {
                        positionFirstBlackHoleX = row;
                        positionFirstBlackHoleY = col;
                    }
                    else
                    {
                        positionSecondBlackHoleX = row;
                        positionSecondBlackHoleY = col;
                    }
                }
            }
        }
    }
}