using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmForOneLightYear = 9450000000000M;

            decimal earthDistance = (decimal)4.22M * kmForOneLightYear;
            decimal ourGalaxy = (decimal)26000M * kmForOneLightYear;
            decimal milkyWay = (decimal)100000M * kmForOneLightYear; 
            decimal universe = (decimal)46500000000M * kmForOneLightYear;

            Console.WriteLine(earthDistance.ToString("e2"));
            Console.WriteLine(ourGalaxy.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(universe.ToString("e2"));

        }
    }
}
