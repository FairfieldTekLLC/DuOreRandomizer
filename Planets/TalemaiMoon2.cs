using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class TalemaiMoon2:Planet
    {
        public TalemaiMoon2()
        {
            FileName = "orepools-40.json";
            NumberOfTiles = 1921;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200,50,5));
            OnPlanetOres.Add(new PlanetOreDef(Ores.NiobiumOre, 0, 200,10,4));
        }
    }
}
