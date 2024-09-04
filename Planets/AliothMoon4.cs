<<<<<<< HEAD
﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class AliothMoon4 : Planet
{
    public AliothMoon4()
    {
        FileName = "orepools-22.json";
        NumberOfTiles = 14521;
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200, 20, 4));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200, 20, 4));
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets
{
    public class AliothMoon4:Planet
    {
        public AliothMoon4()
        {
            FileName = "orepools-22.json";
            NumberOfTiles = 14521;
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.ChromiumOre, 0, 200,20,4));
            OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200,20,4));
        }
    }
}
>>>>>>> 8b9e1d9c2cea918a39407e92ebe4c270c673df62
