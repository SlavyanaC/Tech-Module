using System;

namespace _12.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
