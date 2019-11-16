namespace Vehicles.Core
{
    using Vehicles.Models;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litters)
        {

        }

        public override void Drive(double distance)
        {
            var isDrive = this.FuelQuantity + this.FuelConsumption * distance >= 0;

            if (isDrive)
            {

            }
        }

        public override void Refuel(double litters)
        {
            
        }
    }
}
