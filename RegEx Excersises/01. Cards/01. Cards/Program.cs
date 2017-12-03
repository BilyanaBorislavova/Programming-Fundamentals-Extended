using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCards = Console.ReadLine();

            string pattern = @"([2-9])(\J)|\\[Q]|\K|\A\S|\H|[\\D]|[\\C]";

            Regex regex = new Regex(pattern);
            MatchCollection isMatch = regex.Matches(inputCards);

            foreach (Match card in isMatch)
            {
                Console.WriteLine(card);
            }


        }
    }
}
