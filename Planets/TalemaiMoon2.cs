using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class TalemaiMoon2 : Planet
{
    public TalemaiMoon2()
    {
        FileName = "orepools-40.json";
        NumberOfTiles = 1921;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 10, 200, 50, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NiobiumOre, 10, 200, 10, 4));
    }
}