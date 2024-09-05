using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class MadisMoon1 : Planet
{
    public MadisMoon1()
    {
        FileName = "orepools-10.json";
        NumberOfTiles = 1471;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 10, 200, 10, 4));
    }
}