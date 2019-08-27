using System;
using System.Linq;

namespace _06.BombBasement
{
    public class BombBasement
    {
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizeMatrix[0];
            int column = sizeMatrix[1];
            int[,] matrix = new int[rows, column];

            int bombRow = bombParameters[0];
            int bombCol = bombParameters[1];
            int radius = bombParameters[2];

            while (true)
            {
                matrix[bombRow, bombCol] = 1;

                //TODO...
            }
        }
    }
}
