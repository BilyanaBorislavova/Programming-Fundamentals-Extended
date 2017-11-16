using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(i => i)
                .ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
