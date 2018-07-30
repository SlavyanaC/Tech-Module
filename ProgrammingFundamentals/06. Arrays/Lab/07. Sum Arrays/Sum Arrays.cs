using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sumArray = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }
            foreach (var sum in sumArray)
            {
                Console.Write(sum + " ");
            }
        }
    }
}