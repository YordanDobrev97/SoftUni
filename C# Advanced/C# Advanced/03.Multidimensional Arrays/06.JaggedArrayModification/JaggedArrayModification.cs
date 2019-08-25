using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    public class JaggedArrayModification
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            int[][] matrix = new int[sizeMatrix][];

            for (int row = 0; row < sizeMatrix; row++)
            {
                int[] values = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                matrix[row] = new int[values.Length];
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row][col] = values[col];
                }
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandParts = command.Split();
                string operation = commandParts[0].ToLower();
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (row < 0 || col < 0 || row >=sizeMatrix || col >=sizeMatrix)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (operation == "add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (operation == "subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
