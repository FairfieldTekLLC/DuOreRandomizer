using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using NQ;
using NQutils.Core.Shared;

namespace Ore_Randomizer.Classes
{
    using System.Runtime.InteropServices;
    using NQ;








    public class Pair
    {
        public int TileId { get; set; }
        public int Amount { get; set; }

        public Pair(int tileId, int amount)
        {
            TileId = tileId;
            Amount = amount;
        }
    }





    public static class OreRandomizer
    {

        //public static void GenerateOrePool2(this iPlanet planet)
        //{
        //    List<Pair> Tiles = new();
        //    //Initialize the collection with 0s
        //    for (int i = 1; i <= planet.NumberOfTiles; i++)
        //        Tiles.Add(new Pair(i, 0));

        //    uint[] surrounds = new uint[10];
        //    Tile.NQGetTileNeighbours(planet.altitudeReferenceRadius, planet.territoryTileSize, 1, surrounds);
        //    Debug.WriteLine(surrounds);

        //}




        public static void GenerateOrePool(this iPlanet planet)
        {



            void WriteData(string data)
            {
                File.AppendAllText(planet.FileName, data + "\r\n");
            }

            void Poa(int tile, int amount)
            {
                if (tile != planet.NumberOfTiles)
                    File.AppendAllText(planet.FileName, $"        \"{tile}\" : {amount},\r\n");
                else
                    File.AppendAllText(planet.FileName, $"        \"{tile}\" : {amount} \r\n");

            }

            if (File.Exists(planet.FileName))
                File.Delete(planet.FileName);

            File.WriteAllText(planet.FileName, "");



            Random random = new Random();

            WriteData("{");


            int oreIdx = 1;
            int maxOreIdx = planet.OnPlanetOres.Count;

            Console.WriteLine("Processing Planet: " + planet.GetType());
            foreach (PlanetOreDef def in planet.OnPlanetOres)
            {
                Console.WriteLine("Processing Ore Type: " + def.OreType);
                WriteData($"    \"{def.OreType}\": {{");

                int tileId = 1;
                while (tileId <= planet.NumberOfTiles)
                {
                    Console.WriteLine("Processing Tile: " + tileId);
                    if (def.ChanceOfHavingOre == 100)
                    {
                        int oreAmount = random.Next(0, def.MaxAmount);
                        Poa(tileId, oreAmount);
                        tileId++;
                        continue;
                    }

                    int rnd = random.Next(0, 100);
                    if (rnd < def.ChanceOfHavingOre)
                    {
                        if (def.MaxRun == 0)
                        {
                            def.MaxRun = 1;
                        }

                        int run = random.Next(1, def.MaxRun);
                        for (int i = 0; i < run; i++)
                        {
                            int oreAmount = random.Next(def.MinAmount, def.MaxAmount);
                            tileId += i;
                            if (tileId > planet.NumberOfTiles)
                                break;
                            Poa(tileId, oreAmount);
                        }

                        tileId++;
                    }
                    else
                    {
                        Poa(tileId, 0);
                        tileId++;
                    }
                }

                
                if (oreIdx < maxOreIdx)
                    WriteData("    },");
                else
                    WriteData("    }");
                oreIdx++;

            }
            WriteData("}");

        }
    }
}
