using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class TalemaiMoon3 : Planet
{
    public TalemaiMoon3()
    {
        FileName = "orepools-41.json";
        NumberOfTiles = 1921;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SodiumOre, 10, 200, 20, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ManganeseOre, 10, 200, 20, 4));
    }
}