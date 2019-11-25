
public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput *= 3, energyRequirement * 2)
    {
    }
}

