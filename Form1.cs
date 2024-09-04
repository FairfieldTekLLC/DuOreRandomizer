<<<<<<< HEAD
using System.Text;
using Ore_Randomizer.Classes;
using Ore_Randomizer.Planets;

namespace Ore_Randomizer;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        var output = new StringBuilder();
        output.Append("{\r\n");
        iPlanet planet = new Jago();
        planet.GenerateOrePool();
=======
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ore_Randomizer.Classes;
using Ore_Randomizer.Planets;

namespace Ore_Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            output.Append("{\r\n");
            iPlanet planet = new Jago();
            planet.GenerateOrePool();

        }
>>>>>>> 8b9e1d9c2cea918a39407e92ebe4c270c673df62
    }
}