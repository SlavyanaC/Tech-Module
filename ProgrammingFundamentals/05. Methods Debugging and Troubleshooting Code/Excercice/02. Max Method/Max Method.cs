using System;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            GetMax(first, second);
            Console.WriteLine(Math.Max(GetMax(first, second), third));
        }

        static int GetMax(int first, int second)
        {
            return (Math.Max(first, second));
        }
    }
}
