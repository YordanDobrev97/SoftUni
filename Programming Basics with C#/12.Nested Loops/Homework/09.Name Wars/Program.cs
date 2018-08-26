using System;

namespace _09.Name_Wars
{
    class Program
    {
        static void Main()
        {
            var command = Console.ReadLine();

            var maxValue = 0;
            var winner = string.Empty;
            while (command != "STOP")
            {
                var current = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    current += command[i];
                }

                if (maxValue < current)
                {
                    winner = command;
                    maxValue = current;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} - {maxValue}!");
        }
    }
}
