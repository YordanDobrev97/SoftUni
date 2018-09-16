using System;

namespace _01.ThreeBrothers
{
    class Program
    {
        static void Main()
        {
            double timePerFirstBrother = double.Parse(Console.ReadLine());
            double timePerSecondBrother = double.Parse(Console.ReadLine());
            double timePerThirdBrother = double.Parse(Console.ReadLine());
            double timePerFather = double.Parse(Console.ReadLine());

            double totalTime =1 /(1 / timePerFirstBrother + 1/ 
                timePerSecondBrother + 1 / timePerThirdBrother);

            double timeForRest = totalTime * 0.15;
            timeForRest += totalTime;

            Console.WriteLine($"Cleaning time: {timeForRest:f2}");
            if (timePerFather >= timeForRest)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timePerFather - timeForRest)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeForRest - timePerFather)} hours.");
            }
        }
    }
}
