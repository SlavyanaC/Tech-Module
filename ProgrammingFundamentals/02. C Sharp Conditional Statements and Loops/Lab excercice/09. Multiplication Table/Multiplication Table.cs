using System;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int times = 1;

            while (times <= 10)
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
                times++;
            }
        }
    }
}
