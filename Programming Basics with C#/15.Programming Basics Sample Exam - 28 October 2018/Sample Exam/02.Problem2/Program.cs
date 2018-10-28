using System;
class Program
{
    static void Main()
    {
        double widthShip = double.Parse(Console.ReadLine());
        double lengthShip = double.Parse(Console.ReadLine());
        double heightShip = double.Parse(Console.ReadLine());
        double averageHeight = double.Parse(Console.ReadLine());

        double volume = widthShip * lengthShip * heightShip;
        double volumeRoom = (averageHeight + 0.40) * 4;

        double astronautCount = Math.Floor(volume / volumeRoom);

        if (astronautCount < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        else if(astronautCount > 3 && astronautCount <= 10)
        {
            Console.WriteLine($"The spacecraft holds {astronautCount} astronauts.");
        }
        else
        {
            Console.WriteLine("The spacecraft is too big.");
        }
    }
}

