using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Sicari : Planet
{
    public Sicari()
    {
        FileName = "orepools-6.json";
        NumberOfTiles = 41071;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 10, 200, 10, 10));
        OnPlanetOres.Add(new PlanetOreDef(Ores.GoldOre, 10, 200, 10, 9));
        OnPlanetOres.Add(new PlanetOreDef(Ores.VanadiumOre, 10, 200, 20, 5));
    }
}