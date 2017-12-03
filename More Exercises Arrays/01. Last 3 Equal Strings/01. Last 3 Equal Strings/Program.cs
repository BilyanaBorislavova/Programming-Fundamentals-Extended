using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Reverse()
                 .ToList();
            string word = "";

            for (int i = 0; i < text.Count; i++)
            {
                if(text[i] == text[i + 1] && text[i] == text[i + 2])
                {
                    word = text[i];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(word + " ");
                    }
                    return;
                }
            }

        }
    }
}
