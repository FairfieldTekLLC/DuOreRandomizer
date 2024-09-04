using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class AliothMoon1 : Planet
{
    public AliothMoon1()
    {
        FileName = "orepools-21.json";
        NumberOfTiles = 14521;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SodiumOre, 0, 200, 20, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 0, 200, 20, 5));
    }
}