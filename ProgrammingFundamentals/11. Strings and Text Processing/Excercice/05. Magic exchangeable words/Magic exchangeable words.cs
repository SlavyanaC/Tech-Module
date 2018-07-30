using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var firstWord = input[0];
            var secondWord = input[1];
            var result = ChekIfReplaceble(firstWord, secondWord);
            Console.WriteLine(result.ToString().ToLower());
        }

        static bool ChekIfReplaceble(string firstWord, string secondWord)
        {
            HashSet<char> first = new HashSet<char>();
            HashSet<char> second = new HashSet<char>();
            foreach (var ch in firstWord)
            {
                first.Add(ch);
            }
            foreach (var ch in secondWord)
            {
                second.Add(ch);
            }
            if (first.Count == second.Count)
            {
                return true;
            }
            return false;
        }
    }
}
