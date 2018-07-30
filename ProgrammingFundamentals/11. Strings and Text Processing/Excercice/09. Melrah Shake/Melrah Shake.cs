using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);
                if (firstIndex >= 0 && lastIndex >= 1 && firstIndex != lastIndex)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shake it.");
                }
                else
                {
                    break;
                }
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");

            Console.WriteLine(input);
        }
    }
}
