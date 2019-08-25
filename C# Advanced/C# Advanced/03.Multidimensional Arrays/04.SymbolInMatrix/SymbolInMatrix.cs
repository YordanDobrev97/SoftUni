using System;

namespace _04.SymbolInMatrix
{
    public class SymbolInMatrix
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeMatrix, sizeMatrix];

            for (int row = 0; row < sizeMatrix; row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < sizeMatrix; col++)
                {
                    char currentSymbol = symbols[col];
                    matrix[row, col] = currentSymbol;
                }
            }

            char findSymbol = char.Parse(Console.ReadLine());

            int positionRow = 0;
            int positionCol = 0;
            bool found = false;
            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    char currentSymbol = matrix[row, col];
                    if (currentSymbol == findSymbol)
                    {
                        positionRow = row;
                        positionCol = col;
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine($"({positionRow}, {positionCol})");
            }
            else
            {
                Console.WriteLine($"{findSymbol} does not occur in the matrix");
            }
        }
    }
}
