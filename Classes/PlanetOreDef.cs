<<<<<<< HEAD
﻿namespace Ore_Randomizer.Classes;

public class PlanetOreDef
{
    public PlanetOreDef(string oreType, int minAmount, int maxAmount, int chanceOfHavingOre = 100, int maxRun = 0)
    {
        OreType = oreType;
        MinAmount = minAmount;
        MaxAmount = maxAmount;
        ChanceOfHavingOre = chanceOfHavingOre;
        MaxRun = maxRun;
    }

    public string OreType { get; set; }
    public int MinAmount { get; set; }
    public int MaxAmount { get; set; }

    public int ChanceOfHavingOre { get; set; }

    public int MaxRun { get; set; }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ore_Randomizer.Classes
{
    public class PlanetOreDef
    {
        public string OreType { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }

        public int ChanceOfHavingOre { get; set; }
        
        public int MaxRun { get; set; }

        public PlanetOreDef(string oreType, int minAmount, int maxAmount, int chanceOfHavingOre = 100,int maxRun = 0)
        {
            OreType = oreType;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            ChanceOfHavingOre = chanceOfHavingOre;
            MaxRun=maxRun;
        }
    }
}
>>>>>>> 8b9e1d9c2cea918a39407e92ebe4c270c673df62
