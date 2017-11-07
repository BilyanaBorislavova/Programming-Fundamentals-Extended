using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lightYearsInKM = 9450000000000;
            decimal speedOfLightKmPerSec = 300000;

            decimal all = (lightYearsInKM / speedOfLightKmPerSec) * lightYears;

            TimeSpan time = TimeSpan.FromSeconds((double)all);

            decimal weeks = time.Days / 7;
            decimal days = time.Days % 7;
            decimal hours = time.Hours;
            decimal minutes = time.Minutes;
            decimal seconds = time.Seconds;

            Console.WriteLine($"{weeks:f0} weeks");
            Console.WriteLine($"{days:f0} days");
            Console.WriteLine($"{hours:f0} hours");
            Console.WriteLine($"{minutes:f0} minutes");
            Console.WriteLine($"{seconds:f0} seconds");
        }
    }
}
