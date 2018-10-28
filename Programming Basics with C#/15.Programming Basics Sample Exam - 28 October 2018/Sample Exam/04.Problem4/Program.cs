using System;
class Program
{
    static void Main()
    {
        int widthFreePlace = int.Parse(Console.ReadLine());
        int lengthFreePlace = int.Parse(Console.ReadLine());
        int heightFreePlace = int.Parse(Console.ReadLine());

        int maxCubicMeters = widthFreePlace * lengthFreePlace * heightFreePlace;

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Done")
            {
                Console.WriteLine($"{maxCubicMeters} Cubic meters left.");
                break;
            }
            maxCubicMeters -= int.Parse(command);
            if (maxCubicMeters <=0)
            {
                break;
            }
        }
        if (maxCubicMeters < 0)
        {
            Console.WriteLine($"No more free space! You need {Math.Abs(maxCubicMeters)} Cubic meters more.");
        }
    }
}
