using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class Alioth : Planet
    {
        public Alioth()
        {
            FileName = "orepools-2.json";
            NumberOfTiles = 259471;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 0, 200,25,6));
            OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200,25,7));
        }
    }
}
