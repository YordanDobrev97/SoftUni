using System;


public class StartUp
{
    static int rowPlayer;
    static int colPlayer;

    static void Main()
    {
        string initialString = Console.ReadLine();
        int size = int.Parse(Console.ReadLine());
        char[,] matrix = new char[size, size];

        IntilizateMatrix(matrix);

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }

            switch (command)
            {
                case "up":;
                    if (rowPlayer - 1 >= 0)
                    {
                        matrix[rowPlayer, colPlayer] = '-';
                        rowPlayer--;
                        if (char.IsLetter(matrix[rowPlayer, colPlayer]))
                        {
                            initialString += matrix[rowPlayer, colPlayer];
                        }
                        matrix[rowPlayer, colPlayer] = 'P';
                    }
                    else
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    break;
                case "down":
                    if (rowPlayer + 1 <= matrix.GetLength(0) - 1)
                    {
                        matrix[rowPlayer, colPlayer] = '-';
                        rowPlayer++;
                        if (char.IsLetter(matrix[rowPlayer, colPlayer]))
                        {
                            initialString += matrix[rowPlayer, colPlayer];
                        }
                        matrix[rowPlayer, colPlayer] = 'P';
                    }
                    else
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    break;
                case "left":
                    if (colPlayer - 1 >= 0)
                    {
                        matrix[rowPlayer, colPlayer] = '-';
                        colPlayer--;
                        if (char.IsLetter(matrix[rowPlayer, colPlayer]))
                        {
                            initialString += matrix[rowPlayer, colPlayer];
                        }
                        matrix[rowPlayer, colPlayer] = 'P';
                    }
                    else
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    break;
                case "right":
                    if (colPlayer + 1 <= matrix.GetLength(1) - 1)
                    {

                        matrix[rowPlayer, colPlayer] = '-';
                        colPlayer++;

                        if (char.IsLetter(matrix[rowPlayer, colPlayer]))
                        {
                            initialString += matrix[rowPlayer, colPlayer];
                        }
                        matrix[rowPlayer, colPlayer] = 'P';
                    }
                    else
                    {
                        initialString = initialString.Substring(0, initialString.Length - 1);
                    }
                    break;
            }
        }

        Console.WriteLine(initialString);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row,col]}");
            }
            Console.WriteLine();
        }
    }

    private static void IntilizateMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = line[col];
                if (matrix[row, col] == 'P')
                {
                    rowPlayer = row;
                    colPlayer = col;
                }
            }
        }
    }
}

