using System;

namespace _01.Training_Lab
{
    class TrainingLab
    {
        static void Main()
        {
            double lengthInMeters = double.Parse(Console.ReadLine());
            double widthInMeters = double.Parse(Console.ReadLine());

            double hallInCentimeters = lengthInMeters * 100;
            double hallWidthInCentimeters = (widthInMeters * 100) - 100;

            int offices = (int)hallWidthInCentimeters / 70;
            int rows = (int)hallInCentimeters / 120;

            int numberOfPlaces = offices * rows - 3;
            Console.WriteLine(numberOfPlaces);
        }
    }
}
