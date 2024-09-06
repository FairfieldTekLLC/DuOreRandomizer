using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Jago : Planet
{
    public Jago()
    {
        VoxelGeometryRadius = 63000.0;
        TerritoryTileSize =500.0 ;
        FileName = "orepools-9.json";
        NumberOfTiles = 60751;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 10, 200, 7, 7));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CobaltOre, 10, 200, 5, 8));
        OnPlanetOres.Add(new PlanetOreDef(Ores.TitaniumOre, 10, 200, 5, 5));
    }
}