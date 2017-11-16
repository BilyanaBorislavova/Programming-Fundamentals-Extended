using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chars = Console.ReadLine()
                .Split(' ')
                .ToList();

            for (int i = 0; i < chars.Count; i++)
            {
                string lastEl = chars.Last();
                chars.Remove(lastEl);
                chars.Insert(0, lastEl);
                Console.WriteLine(string.Join(" ", chars));
                break;
            }
            

        }
    }
}
