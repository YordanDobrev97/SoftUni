using System;
using Vehicles.Models.Food;

namespace Vehicles.Core
{
    public class Bus : IVehicle
    {
        private const double AirConditioner = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption += AirConditioner;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= AirConditioner;
            return this.Drive(distance);
        }

        public string Drive(double distance)
        {
            var totalDistance = this.FuelConsumption * distance;

            if (totalDistance <= this.FuelQuantity)
            {
                this.FuelQuantity -= totalDistance;
                return $"Bus travelled {distance} km";
            }

            return $"Bus needs refueling";
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
