using System.Text;
using NQutils.Core.Shared;

namespace Ore_Randomizer.Classes;

public static class OreFlowerGenerator
{
    private static int GetRandomTile(List<int> tiles)
    {
        var r = new Random();
        var index = r.Next(tiles.Count);
        return tiles[index];
    }


    public static void GenerateOrePoolFlowers(this IIPlanet planet)
    {
        var textFile = new StringBuilder();


        if (File.Exists(planet.FileName + ".log"))
            File.Delete(planet.FileName + ".log");
        //Start a new file
        File.WriteAllText(planet.FileName + ".log", "");

        void Log(string data)
        {
            Console.WriteLine(data);
            File.AppendAllText(planet.FileName + ".log", data + "\r\n");
        }


        void WriteData(string data)
        {
            textFile.Append(data + "\r\n");
        }

        //function writes tile data
        void Poa(int tile, int amount)
        {
            textFile.Append(
                tile != planet.NumberOfTiles
                    ? $"        \"{tile}\" : {amount},\r\n"
                    : $"        \"{tile}\" : {amount} \r\n");
        }

        List<int> GetSurroundingTiles(int tileId)
        {
            var t = new uint[20];
            _ = Tile.NQGetTileNeighbours(planet.VoxelGeometryRadius, planet.TerritoryTileSize, tileId, t);
            var tiles = new List<int>();
            for (var i = 0; i < 20; i++)
                if (t[i] != 0)
                    tiles.Add((int)t[i]);
            return tiles;
        }

        List<OreDefinition> oresOnPlanet = new();
        foreach (var def in planet.OnPlanetOres)
        {
            Log("Generating " + def.OreType + " on Planet " + planet);

            var random = new Random();
            var definition = new OreDefinition
            {
                OreAmounts = new int[planet.NumberOfTiles + 1], //0 is not used.                
                OreName = def.OreType
            };

            int getOreDefinition(int tile)
            {
                if (tile >= planet.NumberOfTiles + 1)
                {
                    Log("Warning.....  Out of bounds tile requested!!! on planet: " + planet.ToString() + ", tile: " + tile);
                    return 1;
                }
                else
                    return definition.OreAmounts[tile];
            }

            var tileId = 1;

            while (tileId <= planet.NumberOfTiles)
            {
                if (def.ChanceOfHavingOre == 100 && getOreDefinition(tileId) == 0)
                {
                    definition.OreAmounts[tileId] = random.Next(def.MinAmount, def.MaxAmount);
                    tileId++;
                    continue;
                }

                var rnd = random.Next(0, 100);
                //Do we have ore?  and make sure the tile wasn't used by a flower before.
                if (rnd < def.ChanceOfHavingOre && getOreDefinition(tileId) == 0)
                {
                    if (def.MaxFlowerSize == 0)
                        def.MaxFlowerSize = 1;

                    var realFlowerSize = random.Next(2, def.MaxFlowerSize);
                    Log("Generating " + def.OreType + " Flower Size is " + realFlowerSize);


                    //Track the tiles we have used already
                    var usedTiles = new List<int> { tileId };

                    //Set the ore amount for the center tile.  This also acts as the upper bound for the flower.
                    definition.OreAmounts[tileId] = random.Next(def.MinAmount, def.MaxAmount);

                    //Get Surrounding tiles.
                    var tiles = GetSurroundingTiles(tileId);

                    var minAmount = def.MaxAmount;

                    //Go through each tile in the flower.
                    foreach (var tile in tiles.Where(tile => getOreDefinition(tile) == 0))
                    {
                        //the max the surrounding tiles can have is less than what the center has.
                        definition.OreAmounts[tile] = random.Next(def.MinAmount, definition.OreAmounts[tileId]);
                        //Remember, the ore must be decreasing as we go out.
                        if (definition.OreAmounts[tile] < minAmount)
                            minAmount = definition.OreAmounts[tile];

                        usedTiles.Add(tile);
                        if (usedTiles.Count >= realFlowerSize)
                            break;
                    }


                    while (realFlowerSize >= usedTiles.Count)
                    {
                        var newFlowerCenter = GetRandomTile(tiles);
                        tiles = GetSurroundingTiles(newFlowerCenter);
                        foreach (var usedTile in usedTiles.Where(usedTile => tiles.Contains(usedTile)))
                            tiles.Remove(usedTile);

                        var dataChanged = false;
                        foreach (var tile in tiles.Where(tile => getOreDefinition(tile) == 0))
                        {
                            dataChanged = true;
                            definition.OreAmounts[tile] = random.Next(def.MinAmount, minAmount);
                            usedTiles.Add(tile);
                            if (usedTiles.Count >= realFlowerSize)
                                break;
                        }

                        if (!dataChanged)
                        {
                            //All tiles around us already have a value
                            Log("No tiles left to expand to. Demand: " + realFlowerSize + " Actual: " +
                                usedTiles.Count);
                            break;
                        }

                        if (tiles.Count != 1)
                            continue;

                        List<int> avail = new();
                        foreach (var tile in usedTiles) avail.AddRange(GetSurroundingTiles(tile));

                        avail = avail.Distinct().ToList();

                        foreach (var tile in avail.ToList().Where(tile => usedTiles.Contains(tile)))
                            avail.Remove(tile);

                        tiles = avail;
                    }
                }

                tileId++;
            }

            oresOnPlanet.Add(definition);
        }

        var oreIdx = 1;
        var maxOreIdx = planet.OnPlanetOres.Count;

        if (File.Exists(planet.FileName))
            File.Delete(planet.FileName);
        //Start a new file
        Log("Begin generating file:" + planet.FileName);

        WriteData("{");
        foreach (var def in oresOnPlanet)
        {
            WriteData($"    \"{def.OreName}\": {{");
            for (var i = 1; i <= planet.NumberOfTiles; i++) Poa(i, def.OreAmounts[i]);
            WriteData(oreIdx < maxOreIdx ? "    }," : "    }");
            oreIdx++;
        }

        WriteData("}");
        Log("Finished generating file:" + planet.FileName);
        File.WriteAllText(planet.FileName, textFile.ToString());
    }

    private class OreDefinition
    {
        public int[] OreAmounts;
        public string OreName;
    }
}