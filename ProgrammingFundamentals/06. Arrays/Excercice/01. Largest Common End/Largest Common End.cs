using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            CountLongestEquals(firstArray, secondArray);
            string[] firstArrayReversed = string.Join(" ", firstArray.Reverse()).Split(' ').ToArray();
            string[] secondArrayReversed = string.Join(" ", secondArray.Reverse()).Split(' ').ToArray();
            CountLongestEquals(firstArrayReversed, secondArrayReversed);
            Console.WriteLine(Math.Max(CountLongestEquals(firstArray, secondArray), 
                                       CountLongestEquals(firstArrayReversed, secondArrayReversed)));
        }

        private static int CountLongestEquals(string[] firstArray, string[] secondArray)
        {
            int longestEquels = 0;
            for (int i = 0; i <= Math.Min(firstArray.Length - 1, secondArray.Length - 1); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    longestEquels++;
                }
            }
            return longestEquels;
        }
    }
}
