using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Thades : Planet
{
    public Thades()
    {
        AltitudeReferenceRadius = 49000.0;
        TerritoryTileSize = 500.0;

        FileName = "orepools-3.json";
        NumberOfTiles = 38881;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CopperOre, 10, 200, 20, 9));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 10, 200, 10, 6));
    }
}