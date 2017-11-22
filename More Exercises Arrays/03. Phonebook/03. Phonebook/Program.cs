using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "done")
            {
                if(names.Contains(command))
                {
                    int indexOf = names.IndexOf(command);
                    Console.WriteLine($"{command} -> {numbers.ElementAt(indexOf)}");
                }
              

                command = Console.ReadLine();
            }
        }
    }
}
