using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class SinnenMoon1:Planet
    {
        public SinnenMoon1()
        {
            FileName = "orepools-70.json";
            NumberOfTiles = 4321;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200,30,5));
            OnPlanetOres.Add(new PlanetOreDef(Ores.NiobiumOre, 0, 200,30,6));
        }
    }
}
