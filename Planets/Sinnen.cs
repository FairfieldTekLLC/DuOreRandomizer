using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Sinnen : Planet
{
    public Sinnen()
    {
        VoxelGeometryRadius = 55000.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-7.json";
        NumberOfTiles = 48001;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 10, 200));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 10, 200, 10, 10));
        OnPlanetOres.Add(new PlanetOreDef(Ores.FluorineOre, 10, 200, 20, 7));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ManganeseOre, 10, 200, 20, 5));
    }
}