using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Elements_Equal_to_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == i)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
