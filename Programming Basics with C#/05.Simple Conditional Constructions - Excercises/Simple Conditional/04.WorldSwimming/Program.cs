using System;

namespace _04.WorldSwimming
{
    class Program
    {
        static void Main()
        {
            double seconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double secondSwimming = distanceMeters * timeInSeconds;
            double addSeconds = Math.Floor(distanceMeters / 15);
            addSeconds *= 12.5;

            double totalTime = secondSwimming + addSeconds;

            if (seconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - seconds:f2} seconds slower.");
            }
        }
    }
}
