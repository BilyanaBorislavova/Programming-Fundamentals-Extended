using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char one = (char)('a' + i);
                        char two = (char)('a' + j);
                        char three = (char)('a' + k);
                        Console.WriteLine($"{one}{two}{three}");
                    }
                }
            }
        }
    }
}
