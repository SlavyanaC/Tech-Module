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
            Console.WriteLine(CalculateFactoriel(num));
        }

        static BigInteger CalculateFactoriel (BigInteger num)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
