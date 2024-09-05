using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Alioth : Planet
{
    public Alioth()
    {
        VoxelGeometryRadius = 126000;
        TerritoryTileSize = 500.0000305175781;
        FileName = "orepools-2.json";
        NumberOfTiles = 259471;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 10, 200, 15, 6));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 10, 200, 15, 7));
    }
}