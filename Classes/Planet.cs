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

public class Planet : IIPlanet
{
    /// <summary>
    ///     Altitude Reference Radius--Will be used in future
    /// </summary>
    public double AltitudeReferenceRadius { get; set; }

    /// <summary>
    ///     Territory Tile Size -- Will be used in future
    /// </summary>
    public double TerritoryTileSize { get; set; }

    /// <summary>
    ///     Name of the orepool file
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    ///     Number of tiles on the planet
    /// </summary>
    public int NumberOfTiles { get; set; }

    /// <summary>
    ///     The ore definitions for the planet.
    /// </summary>
    public List<PlanetOreDef> OnPlanetOres { get; set; } = new();
}