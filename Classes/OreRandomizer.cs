namespace Ore_Randomizer.Classes;

public static class OreRandomizer
{
    /// <summary>
    ///     This function generates the ore file for each planet.
    /// </summary>
    /// <param name="planet"></param>
    public static void GenerateOrePool(this IIPlanet planet)
    {
        //function writes data to the file.
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

        //If the pool file exists delete it.
        if (File.Exists(planet.FileName))
            File.Delete(planet.FileName);

        //Start a new file
        File.WriteAllText(planet.FileName, "");

        //Generate a random seed
        var random = new Random();

        //Write opening brace
        WriteData("{");


        var oreIdx = 1;
        var maxOreIdx = planet.OnPlanetOres.Count;


        Console.WriteLine("Processing Planet: " + planet.GetType());
        //Foreach ore definition in the planets ore defs.
        foreach (var def in planet.OnPlanetOres)
        {
            Console.WriteLine("Processing Ore Type: " + def.OreType);
            WriteData($"    \"{def.OreType}\": {{");

            var tileId = 1;
            while (tileId <= planet.NumberOfTiles)
            {
                Console.WriteLine("Processing Tile: " + tileId);
                //If the ore chance is 100 percent than just pull a random in range and continue.
                if (def.ChanceOfHavingOre == 100)
                {
                    var oreAmount = random.Next(def.MinAmount, def.MaxAmount);
                    Poa(tileId, oreAmount);
                    tileId++;
                    continue;
                }

                //Now we handle runs.
                var rnd = random.Next(0, 100);
                //Do we have ore?
                if (rnd < def.ChanceOfHavingOre)
                {
                    if (def.MaxFlowerSize == 0)
                        def.MaxFlowerSize = 1;

                    //how long is the run?
                    var run = random.Next(1, def.MaxFlowerSize);

                    //for the next run tileid's lets give them the same ore.
                    for (var i = 0; i < run; i++)
                    {
                        var oreAmount = random.Next(def.MinAmount, def.MaxAmount);
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


            WriteData(oreIdx < maxOreIdx ? "    }," : "    }");
            oreIdx++;
        }

        WriteData("}");
    }
}