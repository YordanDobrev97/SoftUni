namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public abstract void Refuel(double litters);

        public abstract void Drive(double distance);
    }
}
