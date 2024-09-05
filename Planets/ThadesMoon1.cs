using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesMoon1 : Planet
{
    public ThadesMoon1()
    {
        VoxelGeometryRadius = 14000.0;
        TerritoryTileSize =500.0 ;
        FileName = "orepools-30.json";
        NumberOfTiles = 3001;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CopperOre, 10, 200, 20,8));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 10, 200, 20,8));
    }
}