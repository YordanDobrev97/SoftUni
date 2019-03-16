using System.Collections.Generic;

public class Vehicle
{
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

    public Vehicle(List<Car> cars, List<Truck> trucks)
    {
        this.Trucks = trucks;
        this.Cars = cars;
    }
}
