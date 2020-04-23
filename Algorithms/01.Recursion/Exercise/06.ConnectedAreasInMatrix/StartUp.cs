using System;
using System.Collections.Generic;

namespace ConnectedAreasInMatrix
{
    public class StartUp
    {
        private const char Wall = '*';
        private const char Visited = 'v';
        private static List<Area> areas;

        public class Area : IComparable<Area>
        {
            public Area(int row, int col, int size)
            {
                this.Row = row;
                this.Col = col;
                this.Size = size;
            }

            public int Row { get; set; }

            public int Col { get; set; }

            public int Size { get; set; }

            public int CompareTo(Area other)
            {
                int result = other.Size.CompareTo(this.Size);

                if (result == 0)
                {
                    result = this.Row.CompareTo(other.Row);
                }

                if (result == 0)
                {
                    result = this.Col.CompareTo(other.Col);
                }

                return result;
            }
        }

        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(rows, cols);

            areas = new List<Area>();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    FindConnectionArea(matrix, row, col);
                }
            }

            Console.WriteLine($"Total areas found: {areas.Count}");
            areas.Sort();
            int currentArea = 1;
            foreach (var item in areas)
            {
                Console.WriteLine($"Area #{currentArea} at ({item.Row}, {item.Col}), size: {item.Size}");
                currentArea++;
            }
        }

        private static void FindConnectionArea(char[,] matrix, int row, int col)
        {
            if (matrix[row,col] == Wall || matrix[row,col] == Visited)
            {
                return;
            }

            Area area = new Area(row, col, 0);
            CreateArea(matrix, row, col, area);

            areas.Add(area);
        }

        private static void CreateArea(char[,] matrix, int row, int col, Area area)
        {
            if (!IsRange(matrix, row, col) || matrix[row,col] == Wall
                || matrix[row,col] == Visited)
            {
                return;
            }

            area.Size++;
            matrix[row, col] = Visited;

            CreateArea(matrix, row + 1, col, area); // down
            CreateArea(matrix, row, col + 1, area); // right
            CreateArea(matrix, row - 1, col, area); // up
            CreateArea(matrix, row, col - 1, area); // left
        }

        private static bool IsRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            return matrix;
        }
    }
}