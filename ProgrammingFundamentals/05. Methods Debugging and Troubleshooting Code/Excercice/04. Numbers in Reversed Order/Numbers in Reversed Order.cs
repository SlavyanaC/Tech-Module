using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }

        static string Reverse(string number)
        {
            string result = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i]; 
            }

            return result;
        }
    }
}
