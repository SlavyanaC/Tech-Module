using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var badWords = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var text = Console.ReadLine();
            foreach (var badWord in badWords)
            {
                text = text.Replace(badWord, new string('*', badWord.Length));
            }
            Console.WriteLine(text);
        }
    }
}
