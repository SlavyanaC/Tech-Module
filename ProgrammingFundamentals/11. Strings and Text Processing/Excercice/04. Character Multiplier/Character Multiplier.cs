using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var first = input[0];
            var second = input[1];
            Console.WriteLine(GetSumOfCharMultipl(first, second));
        }

        static int GetSumOfCharMultipl(string first, string second)
        {
            var result = 0;
            List<int> firsAsInt = new List<int>();
            List<int> secondAsInt = new List<int>();
            foreach (var ch in first)
            {
                firsAsInt.Add((int)ch);
            }

            foreach (var ch in second)
            {
                secondAsInt.Add((int)ch);
            }

            for (int i = 0; i < Math.Min(firsAsInt.Count, secondAsInt.Count); i++)
            {
                result += firsAsInt[i] * secondAsInt[i];
            }

            if (firsAsInt.Count != secondAsInt.Count)
            {
                if (firsAsInt.Count > secondAsInt.Count)
                {
                    for (int i = firsAsInt.Count - 1; i >= secondAsInt.Count; i--)
                    {
                        result += (int)firsAsInt[i]; 
                    }
                }
                else
                {
                    for (int i = secondAsInt.Count - 1; i >= firsAsInt.Count; i--)
                    {
                        result += (int)secondAsInt[i];
                    }
                }
            }

            return result;
        }
    }
}
