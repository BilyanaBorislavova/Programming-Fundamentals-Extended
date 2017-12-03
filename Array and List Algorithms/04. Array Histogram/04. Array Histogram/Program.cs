using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> values = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if(!values.ContainsKey(words[i]))
                {
                    values.Add(words[i], 1);
                }
                else
                {
                    values[words[i]]++;
                }
            }

       
             foreach (var word in values.OrderByDescending(x => x.Value))
             {
                var value = ((double)word.Value / words.Count) * 100;
                Console.WriteLine($"{word.Key} -> {word.Value} times ({value:f2}%)");
             }
                     
                
        }
    }
}
