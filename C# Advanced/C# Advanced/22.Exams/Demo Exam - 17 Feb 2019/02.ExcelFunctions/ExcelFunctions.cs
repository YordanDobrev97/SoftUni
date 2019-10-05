using System;
using System.Linq;

namespace _02.ExcelFunctions
{
    public class ExcelFunctions
    {
        public static void Main()
        {
            int countRow = int.Parse(Console.ReadLine());
            string[][] matrix = new string[countRow][];

            for (int i = 0; i < countRow; i++)
            {
                string[] line = Console.ReadLine().Split(", ");
                matrix[i] = line;
            }

            string[] command = Console.ReadLine().Split();
            string header = command[1];

            int colForChange = Array.IndexOf(matrix[0], header);

            if (command[0] == "hide")
            {
                HideHeader(matrix, colForChange);

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join(" | ", row.Where(x => x != null)));
                }
            }
            else if (command[0] == "sort")
            {
                matrix = Sort(matrix, colForChange);
                PrintResult(matrix, header);
            }
            else if (command[0] == "filter")
            {
                string value = command[2];
                FilterHeader(matrix, header, value);
            }
        }

        private static void PrintResult(string[][] matrix, string header)
        {
            PrintFirstHeader(matrix, header);

            foreach (var item in matrix)
            {
                if (!item.Contains(header))
                {
                    Console.WriteLine(string.Join(" | ", item));
                }
            }
        }

        private static void PrintFirstHeader(string[][] matrix, string header)
        {
            foreach (var item in matrix)
            {
                if (item.Contains(header))
                {
                    Console.WriteLine(string.Join(" | ", item));
                    break;
                }
            }
        }

        private static void FilterHeader(string[][] matrix, string header, string value)
        {
            PrintFirstHeader(matrix, header);

            foreach (var item in matrix)
            {
                if (item.Contains(value))
                {
                    Console.WriteLine(string.Join(" | ", item));
                }
            }
        }

        private static string[][] Sort(string[][] matrix, int header)
        {
            var sorted = matrix.OrderBy(x => x[header]).ToArray();
            return sorted;
        }

        private static void HideHeader(string[][] matrix, int colForChange)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row][colForChange] = null;
            }
        }
    }
}
