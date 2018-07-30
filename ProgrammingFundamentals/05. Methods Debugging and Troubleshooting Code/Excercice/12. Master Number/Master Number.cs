using System;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int currentNum = 1; currentNum <= num; currentNum++)
            {
                if (IsPalindrome(currentNum) && SumOfDigits(currentNum) && ContainsEvenDigit(currentNum))
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] == number[number.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            int lastDigit = 0;

            while (num > 0)
            {
                lastDigit = num % 10;
                num /= 10;
                sum += lastDigit;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }

            return false;
        }
    }
}
