using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsOne = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> numsTwo = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = numsOne.Where(i => numsTwo.Contains(i)).ToList();

            foreach (var item in result)
            {
                numsTwo.Remove(item);
            }

            int firstSum = 0;
            int secondSum = 0;


            for (int i = 0; i < numsOne.Count; i++)
            {
                firstSum += numsOne[i];
            }

            for (int i = 0; i < numsTwo.Count; i++)
            {
                secondSum += numsTwo[i];
            }
            int diff = Math.Abs(firstSum - secondSum);

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }


        }
    }
}
