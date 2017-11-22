using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            Name(Console.ReadLine());
        }

        static void Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
