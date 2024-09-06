namespace Ore_Randomizer.Classes;

/// <summary>
///     Interface used to make all planet classes the same.
/// </summary>
public interface IIPlanet
{
    public double VoxelGeometryRadius { get; set; }
    public double TerritoryTileSize { get; set; }
    public string FileName { get; set; }
    public int NumberOfTiles { get; set; }
    public List<PlanetOreDef> OnPlanetOres { get; set; }
}