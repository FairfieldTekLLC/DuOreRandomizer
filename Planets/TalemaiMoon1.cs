using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class TalemaiMoon1:Planet
    {
        public TalemaiMoon1()
        {
            FileName = "orepools-42.json";
            NumberOfTiles = 3631;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CalciumOre, 0, 200,50,5));
            OnPlanetOres.Add(new PlanetOreDef(Ores.VanadiumOre, 0, 200,20,4));
        }
    }
}
