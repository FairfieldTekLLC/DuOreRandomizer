using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class MadisMoon2 : Planet
{
    public MadisMoon2()
    {
        VoxelGeometryRadius = 12000.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-11.json";
        NumberOfTiles = 1921;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CopperOre, 10, 200, 16, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.LithiumOre, 10, 200, 13, 5));
    }
}