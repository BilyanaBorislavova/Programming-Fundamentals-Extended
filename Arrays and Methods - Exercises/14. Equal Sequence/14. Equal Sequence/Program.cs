using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

                if (i < 0 || i < nums.Count)
                {
                    break;
                }
            }
        }
    }
}
