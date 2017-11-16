using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .OrderByDescending(n => n)
               .ToList();

            int m = int.Parse(Console.ReadLine());


            Console.WriteLine(string.Join(" ", nums.Take(m)));
            
          

        }
    }
}
