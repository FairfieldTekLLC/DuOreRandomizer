using BotLib.Utils;
using NQutils.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ore_Randomizer.Classes
{
    public static class OreFlowerGenerator
    {
        public class OreDefinition
        {
            public int[] OreAmounts;
            public string OreName;
        }

        public static int GetRandomTile(List<int> tiles)
        {
            Random r = new Random();
            int index = r.Next(tiles.Count);
            return tiles[index];
        }
        
        


        public static void GenerateOrePoolFlowers(this IIPlanet planet)
        {
            void WriteData(string data)
            {
                File.AppendAllText(planet.FileName, data + "\r\n");
            }

            //function writes tile data
            void Poa(int tile, int amount)
            {
                File.AppendAllText(planet.FileName,
                    tile != planet.NumberOfTiles
                        ? $"        \"{tile}\" : {amount},\r\n"
                        : $"        \"{tile}\" : {amount} \r\n");
            }

            List<int> GetSurroundingTiles(int tileId)
            {
                uint[] t = new uint[20];
                _ = NQutils.Core.Shared.Tile.NQGetTileNeighbours(planet.VoxelGeometryRadius, planet.TerritoryTileSize, tileId, t);
                List<int> tiles = new List<int>();
                for (int i = 0; i < 20; i++)
                {
                    if (t[i] != 0)
                        tiles.Add((int)t[i]);
                }
                return tiles;
            }
            List<OreDefinition> OresOnPlanet = new();
            foreach (PlanetOreDef def in planet.OnPlanetOres)
            {
                
                
                Random random = new Random();
                OreDefinition definition = new OreDefinition();
                definition.OreAmounts = new int[planet.NumberOfTiles + 1];//0 is not used.                
                definition.OreName = def.OreType;

                int tileId = 1;

                while (tileId <= planet.NumberOfTiles)
                {
                    if (def.ChanceOfHavingOre == 100 && definition.OreAmounts[tileId] == 0)
                    {
                        definition.OreAmounts[tileId] = random.Next(def.MinAmount, def.MaxAmount);
                        tileId++;
                        continue;
                    }

                    int rnd = random.Next(0, 100);
                    //Do we have ore?  and make sure the tile wasn't used by a flower before.
                    if (rnd < def.ChanceOfHavingOre && definition.OreAmounts[tileId] == 0)
                    {
                        if (def.MaxFlowerSize == 0)
                            def.MaxFlowerSize = 1;

                        int realFlowerSize = random.Next(2, def.MaxFlowerSize);
                        
                        

                        //Track the tiles we have used already
                        List<int> UsedTiles = new List<int>();

                        UsedTiles.Add(tileId);

                        //Set the ore amount for the center tile.  This also acts as the upper bound for the flower.
                        definition.OreAmounts[tileId] = random.Next(def.MinAmount, def.MaxAmount);

                        //Get Surrounding tiles.
                        var tiles = GetSurroundingTiles(tileId);

                        int minAmount = def.MaxAmount;

                        //Go through each tile in the flower.
                        foreach (int tile in tiles)
                        {
                            if (definition.OreAmounts[tile] == 0)
                            {
                                //the max the surrounding tiles can have is less than what the center has.
                                definition.OreAmounts[tile] = random.Next(def.MinAmount, definition.OreAmounts[tileId]);
                                //Remember, the ore must be decreasing as we go out.
                                if (definition.OreAmounts[tile] < minAmount)
                                    minAmount = definition.OreAmounts[tile];

                                UsedTiles.Add(tile);
                                if (UsedTiles.Count >= realFlowerSize)
                                    break;
                            }
                        }



                        while (realFlowerSize >= UsedTiles.Count)
                        {
                            int newFlowerCenter = GetRandomTile(tiles);
                            tiles = GetSurroundingTiles(newFlowerCenter);
                            foreach (int usedTile in UsedTiles.Where(usedTile => tiles.Contains(usedTile)))
                                tiles.Remove(usedTile);

                            foreach (int tile in tiles)
                            {
                                if (definition.OreAmounts[tile] != 0)
                                {
                                    definition.OreAmounts[tile] = random.Next(def.MinAmount, minAmount);
                                    UsedTiles.Add(tile);
                                    if (UsedTiles.Count >= realFlowerSize)
                                        break;
                                }
                            }
                        }
                    }

                    tileId++;
                }
                
                OresOnPlanet.Add(definition);
            }

            int oreIdx = 1;
            int maxOreIdx = planet.OnPlanetOres.Count;

            if (File.Exists(planet.FileName))
                File.Delete(planet.FileName);
            //Start a new file
            File.WriteAllText(planet.FileName, "");
            WriteData("{");
            foreach (OreDefinition def in OresOnPlanet)
            {
                WriteData($"    \"{def.OreName}\": {{");
                for (int i = 1; i <= planet.NumberOfTiles; i++)
                {
                    Poa(i, def.OreAmounts[i]);
                }
                WriteData(oreIdx < maxOreIdx ? "    }," : "    }");
                oreIdx++;
            }
            WriteData("}");


        }
    }
}
