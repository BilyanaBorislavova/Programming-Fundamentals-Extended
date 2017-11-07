using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder stringg = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());

                char c = Convert.ToChar(m);
                stringg.Append(c);

            }
            Console.WriteLine(stringg);

        }
    }
}
