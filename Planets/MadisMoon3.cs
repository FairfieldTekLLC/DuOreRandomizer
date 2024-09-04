using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class MadisMoon3:Planet
    {
        public MadisMoon3()
        {
            FileName = "orepools-12.json";
            NumberOfTiles = 3631;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200,30,4));
            OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200,30,5));
        }
    }
}
