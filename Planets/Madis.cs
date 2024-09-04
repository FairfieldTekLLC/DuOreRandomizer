using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Madis : Planet
{
    public Madis()
    {
        FileName = "orepools-1.json";
        NumberOfTiles = 30721;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200, 40, 8));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 0, 200, 40, 9));
    }
}