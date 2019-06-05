using System;

namespace _06.MiddleCharacters
{
    public class MiddleCharacters
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            PrintMiddleCharacter(line);
        }

        private static void PrintMiddleCharacter(string line)
        {
            int firstIndex = (line.Length / 2) - 1;
            if (line.Length % 2 == 0)
            {
                int secondIndex = line.Length / 2;

                Console.WriteLine($"{line[firstIndex]}{line[secondIndex]}");
            }
            else
            {
                Console.WriteLine($"{line[firstIndex + 1]}");
            }
        }
    }
}
