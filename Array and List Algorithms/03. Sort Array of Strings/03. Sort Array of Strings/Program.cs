using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split().ToList();

            foreach (var item in text.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
