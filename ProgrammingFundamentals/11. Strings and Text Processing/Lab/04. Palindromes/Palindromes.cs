using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ', '!', '.', '?', ',', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> palindroms = new List<string>();
            foreach (var word in text)
            {
                var firstHalf = word.Substring(0, word.Length / 2);
                var wordBackw = new string(word.Reverse().ToArray());
                var secondHalf = wordBackw.Substring(0, word.Length / 2);
                if (firstHalf.CompareTo(secondHalf) == 0)
                {
                    palindroms.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindroms.Distinct().OrderBy(w => w)));
        }
    }
}
