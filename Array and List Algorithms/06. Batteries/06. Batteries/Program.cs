using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> capacitymAh = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> usagePerHour = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int hours = int.Parse(Console.ReadLine());

            double totalHours = 0;
            double result = 0;

            List<double> totalH = new List<double>();
            List<double> resultmAh = new List<double>();
            List<double> percent = new List<double>();
            List<double> lastedHours = new List<double>();

            double lasted = 0;

            for (int i = 0; i < usagePerHour.Count; i++)
            {
                totalHours = hours * usagePerHour[i];
                totalH.Add(totalHours);
            }

            for (int i = 0; i < capacitymAh.Count; i++)
            {
                result = capacitymAh[i] - totalH[i];
                resultmAh.Add(result);

                lasted = Math.Ceiling(capacitymAh[i] / usagePerHour[i]);
                lastedHours.Add(lasted);
            }


            int batteryCount = 1;
            var dead = "dead";

            var batteryToStr = "";

            double percentage = 0;

            for (int i = 0; i < resultmAh.Count; i++)
            {
                percentage = (resultmAh[i] / capacitymAh[i]) * 100;
                percent.Add(percentage);
            }

            for (int i = 0; i < resultmAh.Count; i++)
            {
                if(resultmAh[i] <= 0)
                {
                    batteryToStr = resultmAh[i].ToString();
                    batteryToStr = dead;
                    Console.WriteLine($"Battery {batteryCount}: {batteryToStr:f2} (lasted {lastedHours[i]} hours)");
                }
                else
                {
                    Console.WriteLine($"Battery {batteryCount}: {resultmAh[i]:f2} mAh ({percent[i]:f2})%");
                }
                batteryCount++;
            }

        }
    }
}
