using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int odd = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] % 2 != 0)
                {
                    odd++;
                }
            }

            Console.WriteLine(odd);
        }
    }
}
