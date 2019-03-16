using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string command = Console.ReadLine();

        List<Car> cars = new List<Car>();
        List<Truck> trucks = new List<Truck>();

        while (command != "end")
        {
            string[] commandParams = command.Split('/');
            string type = commandParams[0];
            string brand = commandParams[1];
            string model = commandParams[2];
            string horsePower = commandParams[3];

            if (type == "Car")
            {
                Car newCar = new Car(brand, model, double.Parse(horsePower));
                cars.Add(newCar);
            }
            else
            {
                Truck newTruck = new Truck(brand, model, int.Parse(horsePower));
                trucks.Add(newTruck);
            }

            command = Console.ReadLine();
        }
        cars = cars.OrderBy(x => x.Brand).ToList();
        trucks = trucks.OrderBy(x => x.Brand).ToList();

        Vehicle vehicle = new Vehicle(cars, trucks);

        Console.WriteLine("Cars:");
        foreach (var car in vehicle.Cars)
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in vehicle.Trucks)
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}

