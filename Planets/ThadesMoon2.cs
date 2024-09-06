using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesMoon2 : Planet
{
    public ThadesMoon2()
    {
        VoxelGeometryRadius = 15000.0;
        TerritoryTileSize =500.0 ;
        FileName = "orepools-31.json";
        NumberOfTiles = 3631;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 10, 200, 12,12));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 10, 200, 13,8));
    }
}