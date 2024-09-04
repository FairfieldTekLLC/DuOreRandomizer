using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Sinnen : Planet
{
    public Sinnen()
    {
        FileName = "orepools-7.json";
        NumberOfTiles = 48001;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 0, 200));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 0, 200, 40, 10));
        OnPlanetOres.Add(new PlanetOreDef(Ores.FluorineOre, 0, 200, 30, 7));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ManganeseOre, 0, 200, 20, 5));
    }
}