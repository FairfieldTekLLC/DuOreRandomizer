using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class ThadesAsteroid20 : Planet
{
    public ThadesAsteroid20()
    {
        VoxelGeometryRadius = 5215.189175235227;
        TerritoryTileSize =500.0;
        FileName = "orepools-420.json";
        NumberOfTiles = 271; //This is a guess
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
    }
}