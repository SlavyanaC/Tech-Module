using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> squareNumbers = new List<int>();
            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNumbers.Add(num);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
