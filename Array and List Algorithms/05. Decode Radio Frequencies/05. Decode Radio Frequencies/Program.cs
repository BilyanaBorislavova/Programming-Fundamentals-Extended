using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> frequencies = Console.ReadLine()
                .Split(new char[] {' ', '.' },StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> firstNums = new List<double>();
            List<double> secondNums = new List<double>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                if(i % 2 != 0)
                {
                    secondNums.Add(frequencies[i]);
                }
                else
                {
                    firstNums.Add(frequencies[i]);
                }
            }

            firstNums.RemoveAll(i => i == 0);
            secondNums.RemoveAll(i => i == 0);
            secondNums.Reverse();

            foreach (var num in firstNums)
            {
                var charValue = (char)num;
                Console.Write(charValue);
            }

            foreach (var num in secondNums)
            {
                var charValue = (char)num;
                Console.Write(charValue);
            }

            Console.WriteLine();

        }
    }
}
