using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var oddCategories = numbers.ToList().Where((c, i) => i % 2 != 0);
            var oddNumbers = oddCategories.Where(num => num % 2 != 0);
            
            foreach (int num in oddNumbers)
            {
                int i = numbers.IndexOf(num);
                Console.WriteLine($"Index {i} -> {num}");
            }


        }
    }
}
