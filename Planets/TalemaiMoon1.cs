using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class TalemaiMoon1 : Planet
{
    public TalemaiMoon1()
    {
        VoxelGeometryRadius = 15000.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-42.json";
        NumberOfTiles = 3631;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 10, 200, 20, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.VanadiumOre, 10, 200, 10, 4));
    }
}