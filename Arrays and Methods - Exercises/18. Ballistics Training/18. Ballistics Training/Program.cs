using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> coordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            double initialX = coordinates[0];
            double initalY = coordinates[1];

            List<string> commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double x = 0;
            double y = 0;

            for (int i = 0; i < commands.Count; i++)
            {
                if(commands[i] == "right")
                {
                    x += int.Parse(commands[i + 1]);
                }

                if(commands[i] == "left")
                {
                    x -= int.Parse(commands[i + 1]);
                }

                if(commands[i] == "up")
                {
                    y += int.Parse(commands[i + 1]);
                }

                if(commands[i] == "down")
                {
                    y -= int.Parse(commands[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");

            if(initialX == x && initalY == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
