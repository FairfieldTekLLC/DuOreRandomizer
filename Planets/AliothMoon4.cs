using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class AliothMoon4 : Planet
{
    public AliothMoon4()
    {
        VoxelGeometryRadius = 30330.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-22.json";
        NumberOfTiles = 14521;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200, 10, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200, 10, 4));
    }
}