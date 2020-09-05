namespace Vehicles
{
    using System;
    using Vehicles.Core;

    public class StartUp
    {
        static void Main()
        {
            string[] carData = Console.ReadLine().Split();
            string[] truckData = Console.ReadLine().Split();
            string[] busData = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carData[1]);
            double carFuelConsumption = double.Parse(carData[2]);
            double carTankCapacity = double.Parse(carData[3]);

            double truckFuelQuantity = double.Parse(truckData[1]);
            double truckFuelConsumption = double.Parse(truckData[2]);
            double truckTankCapacity = double.Parse(truckData[3]);

            double busFuelQuantity = double.Parse(busData[1]);
            double busFuelConsumption = double.Parse(busData[2]);
            double busFuelTankCapacity = double.Parse(busData[3]);


            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busFuelTankCapacity);

            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string[] items = Console.ReadLine().Split();
                string command = items[0];
                string typeVehicle = items[1];
                double value = double.Parse(items[2]);

                if (typeVehicle == "Car")
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(car.Drive(value));
                    }
                    else
                    {
                        car.Refuel(value);
                    }
                }
                else if (typeVehicle == "Truck")
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(truck.Drive(value));
                    }
                    else
                    {
                        truck.Refuel(value);
                    }
                }
                else if (typeVehicle == "Bus")
                {
                    if (command == "DriveEmpty")
                    {
                        Console.WriteLine(bus.DriveEmpty(value));
                    }
                    else if (command == "Drive")
                    {
                        Console.WriteLine(bus.Drive(value));
                    }
                    else
                    {
                        bus.Refuel(value);
                    }
                }
            }

            Console.WriteLine($"Car: {Math.Round(car.FuelQuantity, 2):f2}");
            Console.WriteLine($"Truck: {Math.Round(truck.FuelQuantity, 2):f2}");
            Console.WriteLine($"Bus: {Math.Round(bus.FuelQuantity, 2):f2}");

        }
    }
}
