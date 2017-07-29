using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlant = new GiantPlanet("Saturn", 120540, 5.683*Math.Pow(10,26), "Gas");
            Console.WriteLine(giantPlant.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mars",6794,6.4219*Math.Pow(10,23),true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.ReadKey();
        }
    }
}
