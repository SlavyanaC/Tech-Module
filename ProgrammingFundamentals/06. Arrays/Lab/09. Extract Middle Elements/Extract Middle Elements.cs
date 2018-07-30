using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr.Length;
            if (n == 1)
            {
                ExtractMiddleOneElement(arr);
            }
            else if (n % 2 == 0)
            {
                ExtractMiddleTwoElement(arr);
            }
            else if (n % 2 == 1)
            {
                ExtractMiddleThreeElement(arr);
            }
        }

        static void ExtractMiddleThreeElement(int[] arr)
        {
            Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]}");
        }

        static void ExtractMiddleTwoElement(int[] arr)
        {
            Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}");
        }

        static void ExtractMiddleOneElement(int[] arr)
        {
            Console.Write(arr[0]);
        }
    }
}
