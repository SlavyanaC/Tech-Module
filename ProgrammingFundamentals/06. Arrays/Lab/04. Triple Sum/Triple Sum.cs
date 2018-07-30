using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notFound = true;
            for (int firstDigit = 0; firstDigit < input.Length; firstDigit++)
            {
                for (int secondDigit = firstDigit + 1; secondDigit < input.Length; secondDigit++)
                {
                    int sum = input[firstDigit] + input[secondDigit];
                    if (input.Contains(sum))
                    {
                        Console.WriteLine($"{input[firstDigit]} + {input[secondDigit]} == {sum}");
                        if (notFound)
                        {
                            notFound = false;
                        }
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
