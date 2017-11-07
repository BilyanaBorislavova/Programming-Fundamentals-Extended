using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int sum = 0;

            if(c == '+')
            {
                sum = n + m;
                Console.WriteLine($"{n} {c} {m} = {sum}");
            }
            else if (c == '-')
            {
                sum = n - m;
                Console.WriteLine($"{n} {c} {m} = {sum}");
            }
            else if(c == '/')
            {
                sum = n / m;
                Console.WriteLine($"{n} {c} {m} = {sum}");
            }
            else if (c == '*')
            {
                sum = n * m;
                Console.WriteLine($"{n} {c} {m} = {sum}");
            }

            
        }
    }
}
