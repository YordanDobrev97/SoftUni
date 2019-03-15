using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    public class Train
    {
        public static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] items = command.Split();
                int passengers = 0;
                if (items[0] == "Add")
                {
                    passengers = int.Parse(items[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    passengers = int.Parse(items[0]);
                    AddPassengersInWagon(wagons, maxCapacity, passengers);
                }
                
                command = Console.ReadLine();
            }

            PrintStateWagon(wagons);
        }

        private static void PrintStateWagon(List<int> wagons)
        {
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void AddPassengersInWagon(List<int> wagons, int maxCapacity, int passengers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int wagon = wagons[i];
                if (IsHaveFreePlace(maxCapacity, passengers, wagon))
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }

        private static bool IsHaveFreePlace(int maxCapacity, int passengers, int wagon)
        {
            return wagon + passengers <= maxCapacity;
        }
    }
}
