using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^ _]{3}\.)+([^ _]{3})$";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "ReadMe")
                {
                    break;
                }
                Match match = Regex.Match(input, pattern);

                if (Regex.Match(input, pattern).Success)
                {
                    List<string> matchTokens = match.ToString().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    StringBuilder matchBuilder = new StringBuilder();
                    foreach (var item in matchTokens)
                    {
                        matchBuilder.Append(item);
                    }
                    string matchLine = matchBuilder.ToString();

                    var firstHalf = matchLine.Substring(0, matchLine.Length / 2);
                    var wordBackw = new string(matchLine.Reverse().ToArray());
                    var secondHalf = wordBackw.Substring(0, matchLine.Length / 2);
                    if (firstHalf.CompareTo(secondHalf) == 0)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else if (input.Length == 3 && input[0] == input[2])
                {
                    if (input[0] == input[2])
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
