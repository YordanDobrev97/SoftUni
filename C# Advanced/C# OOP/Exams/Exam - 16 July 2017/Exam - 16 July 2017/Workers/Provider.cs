using System;

public abstract class Provider
{
    private double energyOutput;

    public Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id { get; set; }

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }
        set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }

            this.energyOutput = value;
        }
    }
}

