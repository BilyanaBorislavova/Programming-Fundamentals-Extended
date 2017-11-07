using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool one = true;
          
            for (int i = 1; i <= n; i++)
            {
                int result = i.ToString().Sum(c => c - '0');
                if(result == 5 || result == 7 || result == 11)
                {
                    one = true;
                }
                else
                {
                    one = false;
                }
                Console.WriteLine($"{i} - > {one}");
            }
                

            
        }
    }
}
