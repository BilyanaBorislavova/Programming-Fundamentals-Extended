﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Var_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            int dec = Convert.ToInt32(hex, 16);

            Console.WriteLine(dec);
        }
    }
}
