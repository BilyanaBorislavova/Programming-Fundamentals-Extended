using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split('|').Reverse().ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                int[] nums = tokens[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                result.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
