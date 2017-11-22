using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_El_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
               .Split(' ')
               .ToList();

            List<string> newText = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (i % 2 != 0)
                {
                    newText.Add(text[i]);
                }
            }

            Console.WriteLine(string.Join("", newText));

        }
    }
}
