using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = input.Length / 4;
            int[] leftArray = input.Take(k).Reverse().ToArray();
            int[] rightArray = input.Reverse().Take(k).ToArray();
            int[] firstRow = leftArray.Concat(rightArray).ToArray();
            int[] secondRow = input.Skip(k).Take(2 * k).ToArray();
            var sumArray = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
