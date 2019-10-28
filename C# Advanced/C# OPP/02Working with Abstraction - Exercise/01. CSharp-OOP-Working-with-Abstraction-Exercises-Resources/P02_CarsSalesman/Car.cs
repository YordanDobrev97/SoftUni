using System.Text;

public class Car
{
    private const string offset = "  ";

    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = -1;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
        : this(model, engine)
    {
        this.Weight = weight;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, string color)
        : this(model, engine)
    {
        this.Color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
        : this (model, engine, weight)
    {
        this.Color = color;
    }

    public string Model { get => model; set => model = value; }

    public Engine Engine { get => engine; set => engine = value; }

    public int Weight { get => weight; set => weight = value; }

    public string Color { get => color; set => color = value; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}:\n", this.model);
        sb.Append(this.engine.ToString());
        sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? "n/a" : this.weight.ToString());
        sb.AppendFormat("{0}Color: {1}", offset, this.color);

        return sb.ToString();
    }
}