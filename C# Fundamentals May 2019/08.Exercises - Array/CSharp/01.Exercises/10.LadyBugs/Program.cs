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

            string[] fieldSize = new string[size];

            for (int i = 0; i < size; i++)
            {
                if (indexes.Contains(i))
                {
                    fieldSize[i] = "1";
                }
                else
                {
                    fieldSize[i] = "0";
                }
            }

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] elements = line.Split();
                int currentDirection = int.Parse(elements[0]);
                string direction = elements[1];
                int newDirection = int.Parse(elements[2]);

                if (currentDirection < 0 || currentDirection > fieldSize.Length
                    || newDirection < 0 || newDirection > fieldSize.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }

                bool isFree = fieldSize[newDirection] == "0";

                if (isFree)
                {
                    fieldSize[currentDirection] = "0";
                    fieldSize[newDirection] = "1";
                }
                else
                {
                    while (newDirection < fieldSize.Length)
                    {
                        if (direction == "left")
                        {
                            newDirection--;
                        }
                        else
                        {
                            newDirection++;
                        }
                       

                        if (newDirection >=fieldSize.Length || newDirection < 0)
                        {
                            fieldSize[currentDirection] = "0";
                            break;
                        }
                        isFree = fieldSize[newDirection] == "0";

                        if (isFree)
                        {
                            fieldSize[currentDirection] = "0";
                            fieldSize[newDirection] = "1";
                            break;
                        }
                    }
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", fieldSize));
        }
    }
}
