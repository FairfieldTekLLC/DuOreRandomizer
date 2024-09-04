namespace Ore_Randomizer.Classes;
/*
A list of Materials, together with resources they are refined from looks as follows Quarts refines into
Silicon, Hematite can be turned into Iron,
Coal is a raw precursor of Carbon,
Bauxite turns into Aliminium,
Limestone - Calcium,
Chromite - Chromium,
Malachite - Copper,
Natron - Sodium,
Garnierite - Nickel,
Petalite - Lithium,
Pyrite - Sulfur,
Acanthite - Silver,
Cryolite - Fluorine,
Cobaltite - Cobalt,
Gold Nuggets - Gold,
Kolbectite - Scandium,
Vanadinite - Vanadium,
Ilmenite - Titanium,
Rhondite - Manganese,
Columbite - Niobium
 */

public class Planet : iPlanet
{
    public string FileName { get; set; }
    public int NumberOfTiles { get; set; }
    public List<PlanetOreDef> OnPlanetOres { get; set; } = new();
}