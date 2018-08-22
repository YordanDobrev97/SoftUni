using System;

namespace _04.Walking
{
    class Program
    {
        static void Main()
        {
            int maxStep = 10000;

            string line = Console.ReadLine();

            int currentStep = 0;
            bool isGoingHome = false;
            while (true)
            {
                if (line == "Going home")
                {
                    isGoingHome = true;
                    break;
                }

                int steps = int.Parse(line);
                currentStep += steps;

                if (currentStep >= maxStep)
                {
                    break;
                }

                line = Console.ReadLine();
            }

            if (isGoingHome)
            {
                int stepsGoing = int.Parse(Console.ReadLine());
                currentStep += stepsGoing;
            }

            if (currentStep >= maxStep)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int diff = maxStep - currentStep;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
