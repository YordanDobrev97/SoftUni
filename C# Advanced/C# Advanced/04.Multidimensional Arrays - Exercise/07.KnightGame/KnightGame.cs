using System;
using System.Collections.Generic;

namespace _07.KnightGame
{
    public class KnightGame
    {
        public static int GetCountFightKnight(int row, int col, char[,] matrix)
        {
            int figthKnight = 0;
            int maxLenthRow = matrix.GetLength(0);
            int maxLenthCol = matrix.GetLength(1);

            //up left
            if (row - 2 >= 0 && col - 1 >=0)
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    figthKnight++;
                }
            }

            //up right
            if (row - 2 >=0 && col + 1 < maxLenthCol)
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    figthKnight++;
                }
            }

            //left up
            if (row - 1 >= 0 && col - 2 >= 0)
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    figthKnight++;
                }
            }

            //left down
            if (row + 1 < maxLenthRow && col - 2 >= 0)
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    figthKnight++;
                }
            }

            //right up
            if (row - 1 >= 0 && col + 2 < maxLenthCol)
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    figthKnight++;
                }
            }

            //right down
            if (row + 1 < maxLenthRow && col + 2 < maxLenthCol)
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    figthKnight++;
                }
            }

            //down left
            if (row + 2 < maxLenthRow && col - 1 >= 0)
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    figthKnight++;
                }
            }

            //down right
            if (row + 2 < maxLenthRow && col + 1 < maxLenthCol)
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    figthKnight++;
                }
            }

            return figthKnight;
        }

        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int removeKnightCounter = 0;
            while (true)
            {
                int maxCounter = 0;
                int targetRow = 0;
                int targetCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentSymbol = matrix[row, col];

                        if (currentSymbol == 'K')
                        {
                            int countFightKnight = GetCountFightKnight(row, col, matrix);

                            if (countFightKnight > maxCounter)
                            {
                                maxCounter = countFightKnight;
                                targetRow = row;
                                targetCol = col;
                            }
                        }
                    }
                }

                if (maxCounter == 0)
                {
                    //not attacked knigts
                    break;
                }

                matrix[targetRow, targetCol] = 'O';
                removeKnightCounter++;
            }

            Console.WriteLine(removeKnightCounter);
        }
    }
}
