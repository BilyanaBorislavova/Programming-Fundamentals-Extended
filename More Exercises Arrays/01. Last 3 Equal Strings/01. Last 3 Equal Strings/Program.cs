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


            var duplicateItems = text.GroupBy(x => x).Where(x => x.Count() == 3).Select(x => x.Key);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(string.Join(" ", duplicateItems) + " ");
            }
            
        }
    }
}
