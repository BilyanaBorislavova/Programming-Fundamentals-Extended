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
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 != 0 && nums[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {nums[i]}");
                }
            }
        }
    }
}
