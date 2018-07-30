using System;

namespace _3.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int upperCurrent = 1; upperCurrent <= n; upperCurrent++)
            {
                PrintLine(1, upperCurrent);
            }
            for (int bottomCurrent = n - 1; bottomCurrent >= 1; bottomCurrent--)
            {
                PrintLine(1, bottomCurrent);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int line = start; line <= end; line++)
            {
                Console.Write(line + " ");
            }
            Console.WriteLine();
        }
    }
}
