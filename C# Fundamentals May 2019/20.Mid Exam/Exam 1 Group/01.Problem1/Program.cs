using System;

namespace _01.Problem1
{
    class Program
    {
        static void Main()
        {
            int steps = int.Parse(Console.ReadLine());
            double lengthOfStep = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            double totalSteps = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    totalSteps += lengthOfStep * 0.7;
                }
                else
                {
                    totalSteps += lengthOfStep;
                }
            }

            double distancePrecent = totalSteps / distance;
            Console.WriteLine($"You travelled {distancePrecent:f2}% of the distance!");
        }
    }
}
