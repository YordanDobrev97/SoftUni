namespace Vehicles.Models.Food
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }

        public double FuelConsumption { get; }

        public double TankCapacity { get; }

        public abstract void Refuel(double litters);

        public abstract string Drive(double distance);
    }
}
