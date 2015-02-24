using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * https://github.com/lester88a/COMP123-Assignment-03.git
 * Course: COMP-123
 * Section: 062
 * Student Name: LI XU
 * Student ID: 300735072
 * Date Last Modified:Feb 17, 2015
 * Revision History:Feb 16, 2015. Feb 17, 2015
 */
namespace Assignment_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement GiantPlanet class
            GiantPlanet giantPlanet = new GiantPlanet("Gas", "Mars", 1000, 10);
            Console.WriteLine(giantPlanet.ToString());//display

            Console.WriteLine();

            //Implement TerrestrialPlanet class
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet(true, "Earth", 100, 1);
            Console.WriteLine(terrestrialPlanet.ToString());//display

            //Wait for any key to exit
            WaitKey();
        }

        private static void WaitKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
