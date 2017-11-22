using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Phone
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

            var pattern = @"([\d]+)";

            var result = 0;

            while (command != "done")
            {
                string[] functions = command.Split().ToArray();


                if (functions[0] == "call")
                {
                    if (numbers.Contains(functions[1]))
                    {
                        int indexOf = numbers.IndexOf(functions[1]);
                        var toPrint = names.ElementAt(indexOf);
                        Console.WriteLine($"calling {toPrint}...");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            var regex = Regex.Matches(numbers[i], pattern);
                            foreach (var item in regex)
                            {
                                var each = item.ToString().ToCharArray();
                                result = each.Select(x => int.Parse(x.ToString())).Sum();


                                TimeSpan minutes = TimeSpan.FromSeconds(result);

                                if (result % 2 == 0)
                                {
                                    Console.WriteLine($"call ended. duration: {minutes.ToString((@"mm\:ss"))}");
                                }
                                else
                                {
                                    Console.WriteLine("no answer");
                                }
                            }
                        }

                    }

                    if (names.Contains(functions[1]))
                    {
                        int indexOf = names.IndexOf(functions[1]);
                        var toPrint = numbers.ElementAt(indexOf);
                        Console.WriteLine($"calling {toPrint}...");

                    }

                    

                }

                command = Console.ReadLine();
            }

        }
    }
}
