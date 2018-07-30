using System;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int firstMagicDigit = 0;
            int secondMagicDigit = 0;
            int counter = 0;

            for (int firstDigit = n; firstDigit <= m; firstDigit++)
            {
                for (int secondDigit = n; secondDigit <= m; secondDigit++)
                {
                    if (firstDigit + secondDigit == magicNum)
                    {
                        firstMagicDigit = firstDigit;
                        secondMagicDigit = secondDigit;
                    }
                    counter++;
                }
            }

            if (firstMagicDigit != 0)
            {
                Console.WriteLine($"Number found! {firstMagicDigit} + {secondMagicDigit} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
