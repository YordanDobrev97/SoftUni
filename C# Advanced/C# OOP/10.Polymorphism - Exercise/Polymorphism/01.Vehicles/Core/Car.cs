namespace Vehicles.Core
{
    using System;
    using Vehicles.Models.Food;

    public class Car : IVehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption += 0.9;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double distance)
        {
            var totalDistance = this.FuelConsumption * distance;

            if (totalDistance <= this.FuelQuantity)
            {
                this.FuelQuantity -= totalDistance;
                return $"Car travelled {distance} km";
            }

            return $"Car needs refueling";
        }

        public void Refuel(double litters)
        {
            if (litters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (litters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += litters;
            }
        }
    }
}
