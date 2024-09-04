namespace Ore_Randomizer.Classes;

public class PlanetOreDef
{
    public PlanetOreDef(string oreType, int minAmount, int maxAmount, int chanceOfHavingOre = 100, int maxRun = 0)
    {
        OreType = oreType;
        MinAmount = minAmount;
        MaxAmount = maxAmount;
        ChanceOfHavingOre = chanceOfHavingOre;
        MaxRun = maxRun;
    }

    public string OreType { get; set; }
    public int MinAmount { get; set; }
    public int MaxAmount { get; set; }

    public int ChanceOfHavingOre { get; set; }

    public int MaxRun { get; set; }
}