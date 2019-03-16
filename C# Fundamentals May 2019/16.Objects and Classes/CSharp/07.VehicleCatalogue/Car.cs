
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double HorsePower { get; set; }

    public Car(string brand, string model, double horsePower)
    {
        this.Brand = brand;
        this.Model = model;
        this.HorsePower = horsePower;
    }
}

