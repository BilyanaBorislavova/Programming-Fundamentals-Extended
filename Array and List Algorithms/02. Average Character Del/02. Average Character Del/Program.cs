using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Del
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int num = 0;
            int count = 0;

            foreach (var item in input)
            {
                var iitem = item.ToCharArray();

                foreach (var number in iitem)
                {
                    num += (int)number;
                    count++;
                }
            }

            var average = num / count;

            var toChar = (char)average;

            Console.WriteLine(string.Join($"{toChar.ToString().ToUpper()}", input));

        }
    }
}
