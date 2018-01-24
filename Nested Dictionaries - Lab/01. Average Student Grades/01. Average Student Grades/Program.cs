using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nameGrade = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = nameGrade[0];
                double grade = double.Parse(nameGrade[1]);

                if(!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                if(!students[name].Contains(grade))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var item in students)
            {
                var grades = item.Value;
                var listGrades = new List<string>();

                foreach (var g in grades)
                {
                    listGrades.Add(string.Format("{0:f2}", g));
                }
                Console.WriteLine("{0} -> {1:f2} (avg: {2:f2})", item.Key, string.Join(" ", listGrades), item.Value.Average());
            }
        }
    }
}
