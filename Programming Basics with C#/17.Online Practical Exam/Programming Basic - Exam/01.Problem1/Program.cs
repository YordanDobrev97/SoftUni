using System;

namespace _01.Problem1
{
    class Program
    {
        static void Main()
        {
            double lengthInMeteres = double.Parse(Console.ReadLine());
            double widthInMeters = double.Parse(Console.ReadLine());
            double sideOfBarMeters = double.Parse(Console.ReadLine());

            double roomSize = lengthInMeteres * widthInMeters;
            double barSize = sideOfBarMeters * sideOfBarMeters;
            double dancingSize = roomSize * 0.19;
            double freePlace = roomSize - barSize - dancingSize;

            double countGuest = Math.Ceiling(freePlace / 3.2);
            Console.WriteLine($"{countGuest}");
        }
    }
}
