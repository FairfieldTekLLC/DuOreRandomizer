using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class AliothMoon1 : Planet
{
    public AliothMoon1()
    {
        VoxelGeometryRadius = 30000.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-21.json";
        NumberOfTiles = 14521;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SodiumOre, 10, 200, 10, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 10, 200, 10, 5));
    }
}