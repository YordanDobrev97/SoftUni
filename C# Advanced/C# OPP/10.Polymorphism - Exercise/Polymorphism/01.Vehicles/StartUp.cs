namespace Vehicles
{
    using Vehicles.Core;
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car(15, 0.3);
            car.Drive(30);
        }
    }
}
