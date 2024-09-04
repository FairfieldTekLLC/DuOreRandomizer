<<<<<<< HEAD
﻿using Ore_Randomizer.Classes;

namespace Ore_Randomizer.Planets;

public class Talemai : Planet
{
    public Talemai()
    {
        FileName = "orepools-4.json";
        NumberOfTiles = 52922; //This is a guess
        OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
        OnPlanetOres.Add(new PlanetOreDef(Ores.SodiumOre, 0, 200, 50, 9));
        OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200, 40, 5));
        OnPlanetOres.Add(new PlanetOreDef(Ores.ScandiumOre, 0, 200, 30, 6));
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
    public class Talemai:Planet
    {
        public Talemai()
        {
            FileName = "orepools-4.json";
            NumberOfTiles = 52922;//This is a guess
            OnPlanetOres.Add(new PlanetOreDef(Ores.AluminiumOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.CarbonOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.IronOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SiliconOre, 50, 400));
            OnPlanetOres.Add(new PlanetOreDef(Ores.SodiumOre, 0, 200,50,9));
            OnPlanetOres.Add(new PlanetOreDef(Ores.NickelOre, 0, 200,40,5));
            OnPlanetOres.Add(new PlanetOreDef(Ores.ScandiumOre, 0, 200,30,6));
        }
    }
}
>>>>>>> 8b9e1d9c2cea918a39407e92ebe4c270c673df62
