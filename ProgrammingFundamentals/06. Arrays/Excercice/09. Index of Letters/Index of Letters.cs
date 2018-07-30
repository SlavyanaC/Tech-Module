using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            string input = Console.ReadLine();
            foreach (char letter in input)
            {
                Console.WriteLine(string.Join(" -> ", (char)letter, letter - 'a'));
            }
        }
    }
}
