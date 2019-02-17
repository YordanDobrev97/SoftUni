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
            int middle = line.Length / 2;
            int index = line.Length / 2 - 1;
            if (middle % 2 == 0)
            {
                Console.WriteLine($"{line[index]}{line[index + 1]}");
            }
            else
            {
                Console.WriteLine($"{line[index + 1]}");
            }
        }
    }
}
