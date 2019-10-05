using System;

namespace _02.TronRacers
{
    class Program
    {
        static string[,] matrix;
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new string[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbols[col].ToString();
                }
            }

            int rowFirstPlayer = GetRowFirstPlayer("f"); // first
            int colFirstPlayer = GetColFirstPlayer("f"); // first

            int rowSecondPlayer = GetRowFirstPlayer("s");
            int colSecondPlayer = GetColFirstPlayer("s");

            while (true)
            {
                string[] lineParts = Console.ReadLine().Split();
                string firstPlayer = lineParts[0];
                string secondPlayer = lineParts[1];

                if (firstPlayer == "up")
                {
                    if (IsFreeUp(rowFirstPlayer, colFirstPlayer))
                    {
                        rowFirstPlayer -= 1;
                        matrix[rowFirstPlayer, colFirstPlayer] = "f";
                    }
                    else
                    {
                        if (matrix[rowFirstPlayer - 1, colFirstPlayer] == "s")
                        {
                            matrix[rowFirstPlayer - 1, colFirstPlayer] = "x";
                            break;
                        }
                    }
                }
                else if (firstPlayer == "down")
                {
                    if (IsFreeDown(rowFirstPlayer, colFirstPlayer))
                    {
                        rowFirstPlayer += 1;
                        matrix[rowFirstPlayer, colFirstPlayer] = "f";
                    }
                    else
                    {
                        if (matrix[rowFirstPlayer + 1, colFirstPlayer] == "s")
                        {
                            matrix[rowFirstPlayer + 1, colFirstPlayer] = "x";
                            break;
                        }
                    }
                }
                else if (firstPlayer == "left")
                {
                    if (IsFreeLeft(rowFirstPlayer, colFirstPlayer))
                    {
                        colFirstPlayer -= 1;
                        matrix[rowFirstPlayer, colFirstPlayer] = "f";
                    }
                    else
                    {
                        if (matrix[rowFirstPlayer, colFirstPlayer - 1] == "s")
                        {
                            matrix[rowFirstPlayer, colFirstPlayer - 1] = "x";
                            break;
                        }
                    }
                }
                else
                {
                    if (IsFreeRight(rowFirstPlayer, colFirstPlayer))
                    {
                        colFirstPlayer += 1;
                        matrix[rowFirstPlayer, colFirstPlayer] = "f";
                    }
                    else
                    {
                        if (matrix[rowFirstPlayer, colFirstPlayer + 1] == "s")
                        {
                            matrix[rowFirstPlayer, colFirstPlayer + 1] = "x";
                            break;
                        }
                    }
                }

                if (secondPlayer == "up")
                {
                    if (IsFreeUp(rowSecondPlayer, colSecondPlayer))
                    {
                        rowSecondPlayer -= 1;
                        matrix[rowSecondPlayer, colSecondPlayer] = "s";
                    }
                    else
                    {
                        if (matrix[rowSecondPlayer, colSecondPlayer] == "f")
                        {
                            matrix[rowSecondPlayer, colSecondPlayer] = "x";
                            break;
                        }
                    }
                }
                else if (secondPlayer == "down")
                {
                    if (IsFreeDown(rowSecondPlayer, colSecondPlayer))
                    {
                        rowSecondPlayer += 1;
                        matrix[rowSecondPlayer, colSecondPlayer] = "s";
                    }
                    else
                    {
                        if (matrix[rowSecondPlayer, colSecondPlayer] == "f")
                        {
                            matrix[rowSecondPlayer, colSecondPlayer] = "x";
                            break;
                        }
                    }
                }
                else if (secondPlayer == "left")
                {
                    if (IsFreeLeft(rowSecondPlayer, colSecondPlayer))
                    {
                        colSecondPlayer -= 1;
                        matrix[rowSecondPlayer, colSecondPlayer] = "s";
                    }
                    else
                    {
                        if (matrix[rowSecondPlayer, colSecondPlayer] == "f")
                        {
                            matrix[rowSecondPlayer, colSecondPlayer] = "x";
                            break;
                        }
                    }
                }
                else
                {
                    if (IsFreeRight(rowSecondPlayer, colSecondPlayer))
                    {
                        colSecondPlayer += 1;
                        matrix[rowSecondPlayer, colSecondPlayer] = "s";
                    }
                    else
                    {
                        if (matrix[rowSecondPlayer, colSecondPlayer] == "f")
                        {
                            matrix[rowSecondPlayer, colSecondPlayer] = "x";
                            break;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }

        static int GetColFirstPlayer(string findSymbol)
        {
            int colOfFirstPlayer = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == findSymbol)
                    {
                        colOfFirstPlayer = col;
                    }
                }
            }

            return colOfFirstPlayer;
        }

        static int GetRowFirstPlayer(string findSymbol)
        {
            int rowOfFirstPlayer = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == findSymbol)
                    {
                        rowOfFirstPlayer = row;
                    }
                }
            }

            return rowOfFirstPlayer;
        }

        static bool IsFreeUp(int rowFirstPlayer, int colFirstPlayer)
        {
            if (rowFirstPlayer - 1 < 0)
            {
                return false;
            }
            return matrix[rowFirstPlayer - 1, colFirstPlayer] == "*";
        }

        static bool IsFreeDown(int rowFirstPlayer, int colFirstPlayer)
        {
            if (rowFirstPlayer + 1 > matrix.GetLength(0))
            {
                return false;
            }

            return matrix[rowFirstPlayer + 1, colFirstPlayer] == "*";
        }

        static bool IsFreeLeft(int rowFirstPlayer, int colFirstPlayer)
        {
            if (colFirstPlayer - 1 < 0)
            {
                return false;
            }

            return matrix[rowFirstPlayer, colFirstPlayer - 1] == "*";
        }

        static bool IsFreeRight(int rowFirstPlayer, int colFirstPlayer)
        {
            if (colFirstPlayer + 1 > matrix.GetLength(0) - 1)
            {
                return false;
            }

            return matrix[rowFirstPlayer, colFirstPlayer + 1] == "*";
        }
    }
}
