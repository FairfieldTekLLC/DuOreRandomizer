﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Talemai : Planet
{
    public Talemai()
    {
        VoxelGeometryRadius = 58000.0;
        TerritoryTileSize = 500.0;
        FileName = "orepools-4.json";
        NumberOfTiles = 52922; //This is a guess
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SodiumOre, 10, 200, 17, 9));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 10, 200, 14, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ScandiumOre, 10, 200, 9, 6));
    }
}