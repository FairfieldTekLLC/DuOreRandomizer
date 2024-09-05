﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Madis : Planet
{
    public Madis()
    {
        AltitudeReferenceRadius = 410000.0;
        TerritoryTileSize = 1000.0;
        FileName = "orepools-1.json";
        NumberOfTiles = 30721;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 100, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 10, 200, 10, 8));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 10, 200, 10, 9));
    }
}