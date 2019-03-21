using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.VehicleCatalogue
{
    public interface IVehicle
    {
        string Type { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        double HorsePower { get; set; }
    }

    public class Vehicle : IVehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
    }

    class Car : Vehicle
    {
        public Car(string type, string model, string color, double horsePower) 
            : base(type, model, color, horsePower)
        {
        }
    }

    class Truck : Vehicle
    {
        public Truck(string type, string model, string color, double horsePower) 
            : base(type, model, color, horsePower)
        {
        }
    }

    public class VehicleCatalogue
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var cars = new List<IVehicle>();
            var trucks = new List<IVehicle>();

            while (input != "End")
            {
                var paramInput = input.Split();
                var vehicleType = paramInput[0];
                var model = paramInput[1];
                var color = paramInput[2];
                var horsePower = double.Parse(paramInput[3]);

                if (vehicleType == "car")
                {
                    Car newCar = new Car("Car", model, color, horsePower);
                    cars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck("Truck", model, color, horsePower);
                    trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            var newInput = Console.ReadLine();

            var allCars = new List<List<IVehicle>>();
            var allTrucks = new List<List<IVehicle>>();

            while (newInput != "Close the Catalogue")
            {
                string model = newInput;

                var filterCars = cars.Where(x => x.Model == model).ToList();
                var filterTrucks = trucks.Where(x => x.Model == model).ToList();

                if (filterCars.Count > 0)
                {
                    allCars.Add(filterCars);
                }

                if (filterTrucks.Count > 0)
                {
                    allTrucks.Add(filterTrucks);
                }
                
                newInput = Console.ReadLine();
            }

            foreach (var car in allCars)
            {
                PrintVechicle(car);
            }

            foreach (var truck in allTrucks)
            {
                PrintVechicle(truck);
            }

            double averageHorsePowerCars = 0;
            double averageHorsePowerTrucks = 0;

            if (cars.Count > 0)
            {
                averageHorsePowerCars = cars.Sum(x => x.HorsePower) / cars.Count;
            }

            if (trucks.Count > 0)
            {
                averageHorsePowerTrucks = trucks.Sum(x => x.HorsePower) / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTrucks:f2}.");
        }

        private static void PrintVechicle(List<IVehicle> vehicle)
        {
            foreach (var item in vehicle)
            {
                Console.WriteLine($"Type: {item.Type}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Color: {item.Color}");
                Console.WriteLine($"Horsepower: {item.HorsePower}");
            }
        }
    }
}
