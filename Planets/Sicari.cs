using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public  class Sicari:Planet
    {
        public Sicari()
        {
            FileName = "orepools-6.json";
            NumberOfTiles = 41071;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 0, 200,40,10));
            OnPlanetOres.Add(new PlanetOreDef(Ores.GoldOre, 0, 200,30,9));
            OnPlanetOres.Add(new PlanetOreDef(Ores.VanadiumOre, 0, 200,20,5));
        }
    }
}
