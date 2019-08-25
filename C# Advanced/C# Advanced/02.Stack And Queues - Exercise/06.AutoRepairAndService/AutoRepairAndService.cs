using System;
using System.Collections.Generic;

namespace _06.AutoRepairAndService
{
    public class AutoRepairAndService
    {
        public static void Main()
        {
            string[] carsInput = Console.ReadLine()
                .Split(new char[] {' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>(carsInput);
            Stack<string> servedCars = new Stack<string>();

            while (input != "End")
            {
                string[] commands = input.Split('-');

                string command = commands[0];

                switch (command)
                {
                    case "Service":
                        if (cars.Count > 0)
                        {
                            string currentCar = cars.Dequeue();
                            servedCars.Push(currentCar);
                            Console.WriteLine($"Vehicle {currentCar} got served.");
                        }
                        break;
                    case "CarInfo":
                        string car = commands[1];

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
                        Console.WriteLine(string.Join(", ", servedCars));
                        break;
                }

                input = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            }

            if (servedCars.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }
        }
    }
}
