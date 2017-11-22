using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> newNums = new List<int>();

            newNums.Insert(0, nums[0]);
            int lastElement = nums[nums.Count - 1];

            var range = nums.GetRange(1, nums.Count - 2);
            range.Reverse();

            newNums.InsertRange(1, range);

            newNums.Add(lastElement);


            Console.WriteLine(string.Join(" ", newNums));
        }
    }
}
