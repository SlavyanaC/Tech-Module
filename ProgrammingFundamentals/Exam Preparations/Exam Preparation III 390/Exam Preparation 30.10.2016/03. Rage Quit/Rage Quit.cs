using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^0-9]+)(\d+)";
            StringBuilder result = new StringBuilder();
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string word = match.Groups[1].Value.ToUpper();
                int count = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }

            int uniqueCharsCount = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueCharsCount}");
            Console.WriteLine($"{result}");
        }
    }
}
