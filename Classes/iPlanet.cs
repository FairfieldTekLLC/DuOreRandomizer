using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ore_Randomizer.Classes
{
    public interface iPlanet
    {
        public double altitudeReferenceRadius { get; set; }
        public double territoryTileSize { get; set; }
        public string FileName { get; set; }
        public int NumberOfTiles { get; set; }
        public List<PlanetOreDef> OnPlanetOres { get; set; }
    }
}
