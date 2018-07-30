using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("../../input.txt");
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            bool foundEqualSums = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();
                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("../../output.txt", i.ToString());
                    foundEqualSums = true;
                    break;
                }
            }

            if (!foundEqualSums)
            {
                File.WriteAllText("../../output.txt", "no");
            }
        }
    }
}