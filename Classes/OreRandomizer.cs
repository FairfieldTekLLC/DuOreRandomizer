using System.Diagnostics;
<<<<<<< HEAD

namespace Ore_Randomizer.Classes;

public static class OreRandomizer
{
    public static void GenerateOrePool(this iPlanet planet)
    {
        void WriteData(string data)
        {
            File.AppendAllText(planet.FileName, data + "\r\n");
        }

        void Poa(int tile, int amount)
        {
            File.AppendAllText(planet.FileName,
                tile != planet.NumberOfTiles ? $"\"{tile}\" : {amount} ,\r\n" : $"\"{tile}\" : {amount} \r\n");
        }

        if (File.Exists(planet.FileName))
            File.Delete(planet.FileName);

        File.WriteAllText(planet.FileName, "");


        var random = new Random();

        WriteData("{");


        int oreIdx = 0;
        int maxOreIdx = planet.OnPlanetOres.Count;


        foreach (var def in planet.OnPlanetOres)
        {
            Debug.WriteLine("Processing Ore Type: " + def.OreType);
            WriteData('"' + def.OreType + '"' + ": {");


            int tileId = 1;

            while (tileId <= planet.NumberOfTiles)
            {
                Debug.WriteLine("Processing Tile: " + tileId);

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
                    if (def.MaxRun == 0) def.MaxRun = 1;

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

            WriteData("}");
            oreIdx++;
            if (oreIdx < maxOreIdx)
                WriteData(",");
        }

        WriteData("}");
    }
}
=======
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Ore_Randomizer.Classes
{
    public static class OreRandomizer
    {


        public static void GenerateOrePool(this iPlanet planet)
        {
            
            
            
            void WriteData(string data)
            {
                File.AppendAllText(planet.FileName, data +"\r\n");
            }

            void Poa(int tile, int amount)
            {
                if (tile != planet.NumberOfTiles)
                    File.AppendAllText(planet.FileName, $"\"{tile}\" : {amount} ,\r\n");
                else
                    File.AppendAllText(planet.FileName, $"\"{tile}\" : {amount} \r\n");

            }

            if (File.Exists(planet.FileName))
                File.Delete(planet.FileName);

            File.WriteAllText(planet.FileName, "");



            Random random = new Random();

            WriteData("{");


            int oreIdx = 0;
            int maxOreIdx = planet.OnPlanetOres.Count;


            foreach (PlanetOreDef def in planet.OnPlanetOres)
            {
                Debug.WriteLine("Processing Ore Type: " + def.OreType);
                WriteData('"' + def.OreType + '"' + ": {");


                int tileId = 1;

                while (tileId <= planet.NumberOfTiles)
                {
                    Debug.WriteLine("Processing Tile: " + tileId);

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

                WriteData("}");
                oreIdx++;
                if (oreIdx < maxOreIdx)
                    WriteData(",");
            }
            WriteData("}");

        }
    }
}
>>>>>>> 8b9e1d9c2cea918a39407e92ebe4c270c673df62
