using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string command = Console.ReadLine();

            List<int> valuesToAdd = new List<int>();

            int index = 0;
            while (command != "end")
            {
                int value = int.Parse(command);

                valuesToAdd.Add(value);

                command = Console.ReadLine();
            }

            foreach (var item in valuesToAdd)
            {
                var indexToChar = item.ToString().ToCharArray().First();
                index = int.Parse(indexToChar.ToString());

                nums.Insert(index, item);
            }

            Console.WriteLine(string.Join(" ", nums));

           
        }
    }
}
