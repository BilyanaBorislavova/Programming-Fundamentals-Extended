using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            double capacity = 4 + 8 + 12;

            double fullCourses = Math.Ceiling(people / capacity);
            Console.WriteLine(fullCourses);
        }
    }
}
