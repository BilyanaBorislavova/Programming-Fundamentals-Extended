using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

                if(nums.Contains(n))
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            
        }
    }
}
