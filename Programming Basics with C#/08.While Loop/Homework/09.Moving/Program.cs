using System;


namespace _09.Moving
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int maxCubMeters = width * length * height;
            while (command != "Done")
            {
                int numberCartons = int.Parse(command);
                maxCubMeters -= numberCartons;

                if (maxCubMeters < 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (maxCubMeters >=0)
            {
                Console.WriteLine($"{maxCubMeters} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(maxCubMeters)} Cubic meters more.");
            }
        }

    }
}
