using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PresentDelivery
{
    class Program
    {
        static void Main()
        {
            int[] houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            string line = Console.ReadLine();

            int lastPosition = 0;
            int houseCount = 1;
            int countSteps = 0;

            List<int> visitedHouse = new List<int>();

            while (line != "Merry Xmas!")
            {
                string[] arguments = line.Split();
                int length = int.Parse(arguments[1]);

                for (int i = 0; i < length; i++)
                {
                    countSteps++;

                    if (countSteps >= houses.Length)
                    {
                        countSteps = 0;
                    }
                }

                houses[countSteps] -= length;
                lastPosition = countSteps;
                houseCount++;

                if (houses[countSteps] < 0 && !visitedHouse.Contains(lastPosition))
                {
                    visitedHouse.Add(lastPosition);
                    Console.WriteLine($"House {lastPosition} will have a Merry Christmas.");
                }

                //if (houseCount == houses.Length)
                //{
                //    break;
                //}

                line = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {lastPosition}.");
            if (houseCount == houses.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {houseCount} houses.");
            }

        }
    }
}
