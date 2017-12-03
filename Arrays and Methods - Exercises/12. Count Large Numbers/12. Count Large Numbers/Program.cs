using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Large_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
               .Split()
               .Select(double.Parse)
               .ToList();

            double p = double.Parse(Console.ReadLine());

            int biggerThanP = nums.Where(x => x > p).Count();

            Console.WriteLine(biggerThanP);
        }
    }
}
