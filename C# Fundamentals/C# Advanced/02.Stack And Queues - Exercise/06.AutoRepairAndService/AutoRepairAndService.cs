using System;
using System.Collections.Generic;

namespace _06.AutoRepairAndService
{
    public class AutoRepairAndService
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new [] {' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            Queue<string> cars = new Queue<string>();

            foreach (var value in input)
            {
                cars.Enqueue(value);
            }

            string command = Console.ReadLine();

            Stack<string> servedVehicles = new Stack<string>();

            while (command != "End")
            {
                string[] elements = command.Split('-');

                switch (elements[0])
                {
                    case "Service":
                        string currentCar = cars.Dequeue();
                        Console.WriteLine($"Vehicle {currentCar} got served.");
                        servedVehicles.Push(currentCar);
                        break;
                    case "CarInfo":
                        string car = elements[1];

                        if (cars.Contains(car))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case "History":
                        Console.WriteLine(string.Join(", ", servedVehicles));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");
        }
    }
}
