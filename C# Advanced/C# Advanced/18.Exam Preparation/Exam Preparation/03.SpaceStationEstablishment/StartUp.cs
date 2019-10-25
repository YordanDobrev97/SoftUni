using System;

namespace _03.SpaceStationEstablishment
{
    public class StartUp
    {
        static int rowPlayer;
        static int colPlayer;
        static int rowFirstBlackHole;
        static int colFirstBlackHole;
        static int rowSecondBlackHole;
        static int colSecondBlackHole;

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            IntilizateMatrix(matrix);

            bool isDead = false;
            int starPower = 0;
            int maxPower = 50;
            while (true)
            {
                if (starPower >= maxPower)
                {
                    break;
                }

                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        matrix[rowPlayer, colPlayer] = '-';
                        if (!IsRangeUp(rowPlayer - 1))
                        {
                            isDead = true;
                            break;
                        }

                        if (char.IsDigit(matrix[rowPlayer - 1, colPlayer]))
                        {
                            starPower += matrix[rowPlayer - 1, colPlayer] - '0';
                        }

                        if (IsBlackHole(rowPlayer - 1, colPlayer, matrix))
                        {
                            matrix[rowFirstBlackHole, colFirstBlackHole] = '-';
                            matrix[rowSecondBlackHole, colSecondBlackHole] = 'S';
                            rowPlayer = rowSecondBlackHole;
                            colPlayer = colSecondBlackHole;
                        }
                        else
                        {
                            matrix[rowPlayer - 1, colPlayer] = 'S';
                            rowPlayer -= 1;
                        }
                        break;
                    case "down":
                        matrix[rowPlayer, colPlayer] = '-';
                        if (!IsRangeDown(rowPlayer + 1, matrix))
                        {
                            isDead = true;
                            break;
                        }

                        if (char.IsDigit(matrix[rowPlayer + 1, colPlayer]))
                        {
                            starPower += matrix[rowPlayer + 1, colPlayer] - '0';
                        }

                        if (IsBlackHole(rowPlayer + 1, colPlayer, matrix))
                        {
                            matrix[rowFirstBlackHole, colFirstBlackHole] = '-';
                            matrix[rowSecondBlackHole, colSecondBlackHole] = 'S';
                            rowPlayer = rowSecondBlackHole;
                            colPlayer = colSecondBlackHole;
                        }
                        else
                        {
                            matrix[rowPlayer + 1, colPlayer] = 'S';
                            rowPlayer += 1;
                        }
                        break;
                    case "left":
                        matrix[rowPlayer, colPlayer] = '-';
                        if (!IsRangeLeft(colPlayer - 1))
                        {
                            isDead = true;
                            break;
                        }

                        if (char.IsDigit(matrix[rowPlayer, colPlayer - 1]))
                        {
                            starPower += matrix[rowPlayer, colPlayer - 1] - '0';
                        }

                        if (IsBlackHole(rowPlayer, colPlayer - 1, matrix))
                        {
                            matrix[rowFirstBlackHole, colFirstBlackHole] = '-';
                            matrix[rowSecondBlackHole, colSecondBlackHole] = 'S';
                            rowPlayer = rowSecondBlackHole;
                            colPlayer = colSecondBlackHole;
                        }
                        else
                        {
                            matrix[rowPlayer, colPlayer - 1] = 'S';
                            colPlayer -= 1;
                        }
                        break;
                    case "right":
                        matrix[rowPlayer, colPlayer] = '-';
                        if (!IsRangeRight(colPlayer + 1, matrix))
                        {
                            isDead = true;
                            break;
                        }

                        if (char.IsDigit(matrix[rowPlayer, colPlayer + 1]))
                        {
                            starPower += matrix[rowPlayer, colPlayer + 1] - '0';
                        }

                        if (IsBlackHole(rowPlayer, colPlayer + 1, matrix))
                        {
                            matrix[rowFirstBlackHole, colFirstBlackHole] = '-';
                            matrix[rowSecondBlackHole, colSecondBlackHole] = 'S';
                            rowPlayer = rowSecondBlackHole;
                            colPlayer = colSecondBlackHole;
                        }
                        else
                        {
                            matrix[rowPlayer, colPlayer + 1] = 'S';
                            colPlayer += 1;
                        }
                        break;
                }

                if (isDead)
                {
                    break;
                }
            }

            if (isDead)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {starPower}");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }

        private static bool IsBlackHole(int rowPlayer, int colPlayer, char[,] matrix)
        {
            return matrix[rowPlayer, colPlayer] == 'O';
        }

        private static bool IsRangeRight(int colPlayer, char[,] matrix)
        {
            return colPlayer <= matrix.GetLength(1) - 1;
        }

        private static bool IsRangeLeft(int colPlayer)
        {
            return colPlayer >= 0;
        }

        private static bool IsRangeDown(int rowPlayer, char[,] matrix)
        {
            return rowPlayer <= matrix.GetLength(0) - 1;
        }

        private static bool IsRangeUp(int rowPlayer)
        {
            return rowPlayer >= 0;
        }

        private static void IntilizateMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == 'S')
                    {
                        rowPlayer = row;
                        colPlayer = col;
                    }

                    if (matrix[row,col] == 'O')
                    {
                        if (rowFirstBlackHole == 0 && colFirstBlackHole == 0)
                        {
                            rowFirstBlackHole = row;
                            colFirstBlackHole = col;
                        }
                        else
                        {
                            rowSecondBlackHole = row;
                            colSecondBlackHole = col;
                        }
                    }
                }
            }
        }
    }
}