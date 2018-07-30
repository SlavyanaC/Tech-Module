using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
                            Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                            Select(int.Parse).
                            ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            for (int i = 0; i < rotations; i++)
            {
                int reminder = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                    sum[j] += numbers[j];
                }
                numbers[0] = reminder;
                sum[0] += numbers[0];
            }
            Console.WriteLine($"{string.Join(" ", sum)}");
        }
    }
}
