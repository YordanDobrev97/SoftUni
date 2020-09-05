public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) 
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = (int)this.EnergyRequirement / sonicFactor;
    }

    public int SonicFactor { get; set; }
}

