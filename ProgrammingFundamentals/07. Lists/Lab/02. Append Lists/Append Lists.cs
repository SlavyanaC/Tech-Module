using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                .Split('|');

            List <int> result = new List<int>();
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                int[] elemets = tokens[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                result.AddRange(elemets);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
