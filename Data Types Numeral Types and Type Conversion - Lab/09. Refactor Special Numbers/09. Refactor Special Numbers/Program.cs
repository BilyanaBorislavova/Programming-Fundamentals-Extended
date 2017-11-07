using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int specialNum = 0;
            bool result = false;
            for (int i = 1; i <= number; i++)
            {
                specialNum = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                result = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{specialNum} -> {result}");
                total = 0;
                i = specialNum;
            }

        }
    }
}
