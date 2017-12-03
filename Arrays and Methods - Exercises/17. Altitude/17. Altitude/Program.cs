using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> altitude = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double initialAltitude = double.Parse(altitude[0]);

            bool crash = false;

            for (int i = 0; i < altitude.Count; i++)
            {
                if (initialAltitude <= 0)
                {
                    crash = true;
                    break;
                }
                else
                {
                    crash = false;
                }

                if (altitude[i] == "up")
                {
                    initialAltitude += double.Parse(altitude[i + 1]);
                }

                if(altitude[i] == "down")
                {
                    initialAltitude -= double.Parse(altitude[i + 1]);
                }

            }

            if(crash == true)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitude}m");
            }
            
        }
    }
}
