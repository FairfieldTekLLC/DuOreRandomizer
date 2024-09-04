using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ore_Randomizer.Classes
{
    public interface iPlanet
    {
     public   string FileName { get; set; }
    public    int NumberOfTiles { get; set; }
    public   List<PlanetOreDef> OnPlanetOres { get; set; }
    }
}
