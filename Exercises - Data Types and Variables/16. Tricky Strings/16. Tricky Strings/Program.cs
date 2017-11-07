using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string seperator = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string words = Console.ReadLine();

                result.Append(words);
                result.Append(seperator);
            }
            Console.WriteLine(result.Remove(result.Length - 1, seperator.Length));
        }
    }
}
