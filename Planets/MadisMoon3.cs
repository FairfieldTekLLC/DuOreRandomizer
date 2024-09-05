using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class MadisMoon3 : Planet
{
    public MadisMoon3()
    {
        FileName = "orepools-12.json";
        NumberOfTiles = 3631;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 10, 200, 30, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 10, 200, 30, 5));
    }
}