using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesAsteroid27 : Planet
{
    public ThadesAsteroid27()
    {
        FileName = "orepools-427.json";
        NumberOfTiles = 271; //This is a guess
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
    }
}