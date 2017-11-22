using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine().Split(' ').ToList();

            List<string> songs = new List<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {

                bool b = blackList.Any(command.Contains);

                if (b == false)
                {
                    songs.Add(command);
                }

                command = Console.ReadLine();
            }

            songs.Sort();

            Console.WriteLine(string.Join("\n", songs));
        }
    }
}
