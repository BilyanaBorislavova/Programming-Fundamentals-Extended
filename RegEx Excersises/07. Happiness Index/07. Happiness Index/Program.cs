using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string emotions = Console.ReadLine();

            string happyPattern = @"(\:\))|(\:[\\D])|(\;\))|(\:[\\*])|(\:\])|(\;\])|(\:\})|(\;\})|(\(\:)|([\\*]\:)|([\\c]\:|(\[\:)|(\[\;))";
            string sadPattern = @"((\:\()|([\\D]\:)|(\;\()|(\:\[)|(\;\[)|(\:\{)|(\;\{)|(\)\:)|(\:[\\c])|(\]\:)|(\]\;))";

            Regex happyRegex = new Regex(happyPattern);
            Regex sadRegex = new Regex(sadPattern);

            MatchCollection happyMatch = happyRegex.Matches(emotions);
            MatchCollection sadMatch = sadRegex.Matches(emotions);

            List<string> happyEmotions = new List<string>();
            List<string> sadEmotions = new List<string>();

            foreach (Match happiness in happyMatch)
            {
                happyEmotions.Add(happiness.ToString());
            }

            foreach (Match sadness in sadMatch)
            {
                sadEmotions.Add(sadness.ToString());
            }

            double happyCount = happyEmotions.Count();
            double sadCount = sadEmotions.Count();
            double index = happyCount / sadCount;


            if (index >= 2)
            {
                Console.WriteLine($"Happiness index: {index:f2} :D");
            }
            else if (index > 1)
            {
                Console.WriteLine($"Happiness index: {index:f2} :)");
            }
            else if (index == 1)
            {
                Console.WriteLine($"Happiness index: {index:f2} :|");
            }
            else if (index < 1)
            {
                Console.WriteLine($"Happiness index: {index:f2} :(");
            }

            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");


        }
    }
}
