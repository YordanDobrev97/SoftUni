using System;

namespace _02.Dance_hall
{
    class DanceHall
    {
        private const int placePerDancer = 40;
        private const int placePerMove = 7000;
        static void Main()
        {
            double lengthPerHallMeters = double.Parse(Console.ReadLine());
            double widthPerHallMeters = double.Parse(Console.ReadLine());
            double sidePerWardrobeMeters = double.Parse(Console.ReadLine());

            double hallSizeInCentimeters = (lengthPerHallMeters * 100) * (widthPerHallMeters * 100);
            double sizePerWardrobe = (sidePerWardrobeMeters * 100) * (sidePerWardrobeMeters * 100);
            double sizePerBench = hallSizeInCentimeters / 10;
            double freePlace = hallSizeInCentimeters - sizePerWardrobe - sizePerBench;

            double numberDancers = freePlace / (placePerDancer + placePerMove);
            Console.WriteLine(Math.Round(numberDancers, 0));
        }
    }
}
