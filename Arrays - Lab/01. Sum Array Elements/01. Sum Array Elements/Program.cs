using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nums = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                nums = int.Parse(Console.ReadLine());

                sum += nums;
            }
                Console.WriteLine(sum);
            
            
        }
    }
}
