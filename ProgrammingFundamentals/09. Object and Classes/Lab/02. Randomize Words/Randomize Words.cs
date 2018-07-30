using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int firstWord = random.Next(0, words.Length);
                int secondWord = random.Next(0, words.Length);
                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
