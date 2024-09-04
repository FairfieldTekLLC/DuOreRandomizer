using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesAsteroid02 : Planet
{
    public ThadesAsteroid02()
    {
        FileName = "orepools-402.json";
        NumberOfTiles = 271; //This is a guess
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ManganeseOre, 0, 20, 10, 3));
    }
}