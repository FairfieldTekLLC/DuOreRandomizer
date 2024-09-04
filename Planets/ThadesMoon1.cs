using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class ThadesMoon1:Planet
    {
        public ThadesMoon1()
        {
            FileName = "orepools-30.json";
            NumberOfTiles = 3001;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CopperOre, 0, 200,40));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SulfurOre, 0, 200,40));
        }
    }
}
