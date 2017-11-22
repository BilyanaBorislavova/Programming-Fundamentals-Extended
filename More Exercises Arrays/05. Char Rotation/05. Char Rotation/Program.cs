using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = Console.ReadLine();

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<char> values = new List<char>(chars);

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    values[i] -= (char)(numbers[i]);
                }
                else
                {
                    values[i] += (char)(numbers[i]);
                }
            }

            Console.WriteLine(string.Join("", values));
        }
    }
}
