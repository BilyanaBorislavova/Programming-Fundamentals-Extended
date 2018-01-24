using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToList();

            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
               nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                foreach (var item in nums)
                {
                    if(primalList.Contains(item))
                    {
                        primalList.RemoveAll(m => m == item);
                    }
                    else
                    {
                        primalList.Add(item);
                    }
                }
            }

            primalList.Sort();
           Console.WriteLine(string.Join(" ", primalList));


        }
    }
}
