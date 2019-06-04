using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] fieldSize = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (indexes.Contains(i))
                {
                    fieldSize[i] = 1;
                }
                else
                {
                    fieldSize[i] = 0;
                }
            }

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] elements = line.Split();
                int currentDirection = int.Parse(elements[0]);
                string direction = elements[1];
                int newDirection = int.Parse(elements[2]);

                if (currentDirection >= fieldSize.Length || currentDirection < 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (fieldSize[currentDirection] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                int index = currentDirection;
                while (true)
                {
                    if (direction == "right")
                    {
                        index += newDirection;
                    }
                    else if (direction == "left")
                    {
                        index -= newDirection;
                    }
                    else
                    {
                        break;
                    }

                    if (index >= fieldSize.Length || index < 0)
                    {
                        fieldSize[currentDirection] = 0;
                        break;
                    }

                    if (fieldSize[index] == 0)
                    {
                        fieldSize[index] = 1;
                        fieldSize[currentDirection] = 0;
                        break;
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", fieldSize));
        }
    }
}
