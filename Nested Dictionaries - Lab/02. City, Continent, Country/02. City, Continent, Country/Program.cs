using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.City__Continent__Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> ccc = new Dictionary<string, Dictionary<string, List<string>>>();

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
                    ccc.Add(continent, new Dictionary<string, List<string>>());
                }

                if(!ccc[continent].ContainsKey(country))
                {
                    ccc[continent].Add(country, new List<string>());
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
