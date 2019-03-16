
public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

    public Truck(string brand, string model, int weight)
    {
        this.Brand = brand;
        this.Model = model;
        this.Weight = weight;
    }
}

