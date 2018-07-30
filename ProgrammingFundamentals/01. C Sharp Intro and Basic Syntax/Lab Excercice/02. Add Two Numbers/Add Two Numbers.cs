using System;

namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
        }
    }
}
