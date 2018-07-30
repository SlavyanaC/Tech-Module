using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var sortedNumbers = numbers.OrderByDescending(x => x);
            var largestThreeNumbers = sortedNumbers.Take(3).ToArray();
            Console.WriteLine(string.Join(" ", largestThreeNumbers));
        }
    }
}
