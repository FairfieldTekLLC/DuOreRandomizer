using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesMoon2 : Planet
{
    public ThadesMoon2()
    {
        FileName = "orepools-31.json";
        NumberOfTiles = 3631;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 0, 200, 60));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200, 35));
    }
}