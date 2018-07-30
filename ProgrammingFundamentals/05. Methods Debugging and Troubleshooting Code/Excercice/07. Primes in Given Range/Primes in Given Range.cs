using System;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            GetPrime(num1, num2);

        }

        static void GetPrime(int num1, int num2)
        {
            if (num1 < 2)
            {
                num1 = 2;
            }
            bool firstPrime = true;
            for (int isPrime = num1; isPrime <= num2; isPrime++)
            {
                bool Prime = true;
                for (int numberinside = 2; numberinside <= Math.Sqrt(isPrime); numberinside++)
                {
                    if (isPrime % numberinside == 0)
                    {
                        Prime = false;
                        break;
                    }
                }

                if (Prime == true && firstPrime == true)
                {
                    Console.Write(isPrime);
                    firstPrime = false;
                }
                else if (Prime)
                {
                    Console.Write(", ");
                    Console.Write(isPrime);
                }
            }
            Console.WriteLine();
        }
    }
}