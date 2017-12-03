using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                nums.Add(m);
            }

            int negatives = nums.Where(x => x < 0).Count();
            Console.WriteLine(negatives);
        }
    }
}
