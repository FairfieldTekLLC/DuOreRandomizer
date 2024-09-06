namespace Ore_Randomizer.Classes;

public class PlanetOreDef
{
    public PlanetOreDef(string oreType, int minAmount, int maxAmount, int chanceOfHavingOre = 100,
        int maxFlowerSize = 0)
    {
        OreType = oreType;
        MinAmount = minAmount;
        MaxAmount = maxAmount;
        ChanceOfHavingOre = chanceOfHavingOre;
        MaxFlowerSize = maxFlowerSize;
    }

    /// <summary>
    ///     The ore type
    /// </summary>
    public string OreType { get; set; }

    /// <summary>
    ///     The minimum amount of ore you want on a tile.  Lower Bound
    /// </summary>
    public int MinAmount { get; set; }


    /// <summary>
    ///     The max amount of ore you want on a tile.  Upper bound.
    /// </summary>
    public int MaxAmount { get; set; }


    /// <summary>
    ///     The chance that the tile will have ore.
    ///     This is optional and is used in conjunction with the property below.
    ///     It defaults to 100 percent
    /// </summary>
    public int ChanceOfHavingOre { get; set; }


    /// <summary>
    ///     If the tile has ore, how long of a run will the ore be.
    ///     It defaults to 0.
    /// </summary>
    public int MaxFlowerSize { get; set; }
}