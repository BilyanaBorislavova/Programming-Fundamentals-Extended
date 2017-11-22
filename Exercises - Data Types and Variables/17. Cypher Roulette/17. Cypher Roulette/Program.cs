using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                if (word == "spin")
                {
                    word = Console.ReadLine();
                    result.Insert(0, word);
                }

                

               
                result.Append(word);

            }

            Console.WriteLine(result);
        }
    }
}
