using System;

namespace _06.Prime_Checker
{
    class Program
    {
        public static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(ChackPrime(num));
        }

        private static bool ChackPrime(long num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            for (int currentNum = 2; currentNum <= Math.Sqrt(num); currentNum++)
            {
                if (num % currentNum == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
