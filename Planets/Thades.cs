using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class Thades:Planet
    {
        public Thades()
        {
            FileName = "orepools-3.json";
            NumberOfTiles = 38881;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CopperOre, 0, 200,50,9));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SilverOre, 0, 200,40,6));
        }
    }
}
