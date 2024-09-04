using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class MadisMoon2 : Planet
{
    public MadisMoon2()
    {
        FileName = "orepools-11.json";
        NumberOfTiles = 1921;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CopperOre, 0, 200, 30, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.LithiumOre, 0, 200, 30, 5));
    }
}