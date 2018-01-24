using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> frequencies = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();


            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            List<string> notes = new List<string>();
            List<double> naturalsSum = new List<double>();
            List<double> sharpsSum = new List<double>();

            for (int i = 0; i < frequencies.Count; i++)
            {
                if(frequencies[i] == 261.63)
                {
                    naturals.Add("C");
                    notes.Add("C");
                    naturalsSum.Add(261.63);
                }

                if(frequencies[i] == 277.18)
                {
                    sharps.Add("C#");
                    notes.Add("C#");
                    sharpsSum.Add(277.18);
                }

                if(frequencies[i] == 293.66)
                {
                    naturals.Add("D");
                    notes.Add("D");
                    naturalsSum.Add(293.66);
                }

                if(frequencies[i] == 311.13)
                {
                    sharps.Add("D#");
                    notes.Add("D#");
                    sharpsSum.Add(311.13);
                }

                if(frequencies[i] == 329.63)
                {
                    naturals.Add("E");
                    notes.Add("E");
                    naturalsSum.Add(329.63);
                }

                if(frequencies[i] == 349.23)
                {
                    naturals.Add("F");
                    notes.Add("F");
                    naturalsSum.Add(349.23);
                }

                if(frequencies[i] == 369.99)
                {
                    sharps.Add("F#");
                    notes.Add("F#");
                    sharpsSum.Add(369.99);
                }

                if(frequencies[i] == 392.00)
                {
                    naturals.Add("G");
                    notes.Add("G");
                    naturalsSum.Add(392.00);
                }

                if(frequencies[i] == 415.30)
                {
                    sharps.Add("G#");
                    notes.Add("G#");
                    sharpsSum.Add(415.30);
                }

                if(frequencies[i] == 440.00)
                {
                    naturals.Add("A");
                    notes.Add("A");
                    naturalsSum.Add(440.00);
                }

                if(frequencies[i] == 466.16)
                {
                    sharps.Add("A#");
                    notes.Add("A#");
                    sharpsSum.Add(466.16);
                }

                if(frequencies[i] == 493.88)
                {
                    naturals.Add("B");
                    notes.Add("B");
                    naturalsSum.Add(493.88);
                }

            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");

            var naturalSum = naturalsSum.Sum();
            var sharpSum = sharpsSum.Sum();

            Console.WriteLine($"Naturals sum: {string.Join("", naturalSum)}");
            Console.WriteLine($"Sharps sum: {string.Join("", sharpSum)}");
        }
    }
}
