using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> newListNumbers = new List<int>(numbers);
            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    newListNumbers.Remove(number);
                }
            }
            if (newListNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                newListNumbers.Reverse();
                Console.WriteLine(string.Join(" ", newListNumbers));
            }
        }

    }
}
