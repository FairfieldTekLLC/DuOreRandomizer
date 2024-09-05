using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Teoma : Planet
{
    public Teoma()
    {
        VoxelGeometryRadius = 61000.0;
        TerritoryTileSize =500.0 ;
        FileName = "orepools-8.json";
        NumberOfTiles = 60751;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.LithiumOre, 10, 200, 20, 9));
        OnPlanetOres.Add(new PlanetOreDef(Ores.FluorineOre, 10, 200, 30, 5));
    }
}