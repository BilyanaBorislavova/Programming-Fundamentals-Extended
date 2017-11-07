using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte num = 0;

            int overflows = 0;

            for (int i = 0; i < n; i++)
            {
                num++;

                if (num == 0)
                {
                    overflows++;
                }

            }
            Console.WriteLine(num);
            Console.WriteLine($"Overflowed {overflows} times");
        }
    }
}
