using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            bool hasSummed = true;
            while (hasSummed)
            {
                hasSummed = false;
                int index = 0;
                decimal sum = 0;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        index = i - 1;
                        sum = numbers[i] + numbers[i - 1];
                        hasSummed = true;
                        break;
                    }
                }

                if (hasSummed)
                {
                    numbers.RemoveRange(index, 2);
                    numbers.Insert(index, sum);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
