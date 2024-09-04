using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class MadisMoon1 : Planet
{
    public MadisMoon1()
    {
        FileName = "orepools-10.json";
        NumberOfTiles = 1471;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 0, 200, 30, 4));
    }
}