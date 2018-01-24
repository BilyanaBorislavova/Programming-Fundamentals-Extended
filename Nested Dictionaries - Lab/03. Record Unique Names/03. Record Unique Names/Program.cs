using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> name = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();

                if(!name.Contains(names))
                {
                    name.Add(names);
                }
            }

            Console.WriteLine(string.Join("\n", name));
        }
    }
}
