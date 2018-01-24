using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();

            int m = int.Parse(Console.ReadLine());

            int count = 0;

            if (nums.Count == m)
            {
                Console.WriteLine($"already stable: {string.Join(" ", nums)}");
            }
            else
            { 

            while (m < nums.Count)
            {
                for (int i = m; i < nums.Count; i++)
                {
                    nums.RemoveAt(0);
                    nums.RemoveAt(nums.Count - 1);
                    count++;
                }
            }
                Console.WriteLine($"{count} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", nums)}");
            }
        }
    }
}
