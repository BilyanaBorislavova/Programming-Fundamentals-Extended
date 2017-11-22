using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "end")
            {
                if(commands[0] == "push")
                {
                    int num = int.Parse(commands[1]);
                    numbers.Add(num);
                }

                if(commands[0] == "pop")
                {
                    numbers.RemoveAt(numbers.Count - 1);
                }

                if(commands[0] == "removeAt")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);
                }

                if(commands[0] == "clear")
                {
                    numbers.Clear();
                }

                commands = Console.ReadLine().Split(' ').ToArray();
            }

            if (numbers.Count <= 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
