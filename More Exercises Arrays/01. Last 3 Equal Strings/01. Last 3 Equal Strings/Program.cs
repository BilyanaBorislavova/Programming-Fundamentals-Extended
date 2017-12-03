using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();


            for (int i = 0; i < text.Count; i++)
            {
                int thirdElement = text.Count - 1;
                int secondElement = thirdElement - 1;
                int firstElement = secondElement - 1;

                string third = text.ElementAt(thirdElement);
                string second = text.ElementAt(secondElement);
                string first = text.ElementAt(firstElement);

                if(third.Equals(second) && second.Equals(first))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
