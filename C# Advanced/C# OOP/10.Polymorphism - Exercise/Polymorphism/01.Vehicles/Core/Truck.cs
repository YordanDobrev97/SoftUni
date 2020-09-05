using System;
using Vehicles.Models.Food;

namespace Vehicles.Core
{
    public class Truck : IVehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption += 1.6;
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
                return $"Truck travelled {distance} km";
            }
            return "Truck needs refueling";
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
                litters *= 0.95;
                this.FuelQuantity += litters;
            }
            
        }
    }
}
