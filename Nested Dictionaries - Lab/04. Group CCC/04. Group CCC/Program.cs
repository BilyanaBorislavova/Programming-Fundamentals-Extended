using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_CCC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> ccc 
                = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if(!ccc.ContainsKey(continent))
                {
                    ccc.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }

                if(!ccc[continent].ContainsKey(country))
                {
                    ccc[continent].Add(country, new SortedSet<string>());
                }

                ccc[continent][country].Add(city);
            }

            foreach (var item in ccc)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var itemm in item.Value)
                {
                    Console.WriteLine($"  {itemm.Key} -> {string.Join(", ", itemm.Value)}");
                }
            }
        }
    }
}
