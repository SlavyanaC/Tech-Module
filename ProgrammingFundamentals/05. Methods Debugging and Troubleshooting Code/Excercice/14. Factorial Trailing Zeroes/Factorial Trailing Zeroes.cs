using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger factoriel = CalculateFactoriel(num);
            Console.WriteLine(CountTrailingZeroes(factoriel));
        }

        static BigInteger CalculateFactoriel(BigInteger num)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }

        static BigInteger CountTrailingZeroes(BigInteger factoriel)
        {
            int trailingZeroes = 0;
            while (factoriel > 0)
            {
                BigInteger lastDigit = factoriel % 10;
                factoriel /= 10;
                if (lastDigit == 0)
                {
                    trailingZeroes++;
                }
                if (lastDigit != 0)
                {
                    break;
                }
            }
            return trailingZeroes;
        }
    }
}
