using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());

            decimal toBits = (decimal)terabytes * 1024M * 1024M * 1024M * 1024M * 8M;

            Console.WriteLine($"{toBits:f0}");

        }
    }
}
