using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int multiplication = GetGetMultipleOfEvensAndOdds(num);
            Console.WriteLine(GetGetMultipleOfEvensAndOdds(num));
        }

        static int GetGetMultipleOfEvensAndOdds(int num)
        {
            int sumEven = GetSumEvenDigit(num);
            int sumOdd = GetSumOddDigit(num);
            return sumEven * sumOdd;
        }

        static int GetSumEvenDigit(int num)
        {
            int sumEven = 0;
            while (num > 0)
            {
                int currentDigit = num % 10;
                num /= 10;

                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
            }
            return sumEven;
        }

        static int GetSumOddDigit(int num)
        {
            int sumOdd = 0;
            while (num > 0)
            {
                int currentDigit = num % 10;
                num /= 10;

                if (currentDigit % 2 == 1)
                {
                    sumOdd += currentDigit;
                }
            }
            return sumOdd;
        }
    }
}
