using System;
using System.Collections.Generic;
using System.IO;
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
            var input = File.ReadAllText("../../input.txt");
            foreach (char letter in input)
            {
                File.AppendAllText("../../output.txt", (string.Join(" -> ", (char)letter, letter - 'a' + Environment.NewLine)));
            }
        }
    }
}
