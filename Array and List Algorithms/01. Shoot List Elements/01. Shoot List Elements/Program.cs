using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<int> nums = new List<int>();

            int toRemove = 0;

            while ((command = Console.ReadLine()) != "stop")
            {
                if (command != "bang")
                {
                    int n = int.Parse(command);
                    nums.Insert(0, n);
                }

                if (command == "bang")
                {
                    try
                    {
                        var average = nums.Average();
                        if (nums.Count - 1 > 0)
                        {
                            toRemove = nums.Where(x => x < average).First();
                        }
                        else
                        {
                            toRemove = nums.ElementAt(0);
                        }
                        Console.WriteLine($"shot {toRemove}");
                        nums.Remove(toRemove);

                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums[i]--;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {toRemove}");
                        return;
                    }
                   
                }
            }

            if (nums.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ", nums)}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {toRemove}");
            }
 



        }
    }
}
