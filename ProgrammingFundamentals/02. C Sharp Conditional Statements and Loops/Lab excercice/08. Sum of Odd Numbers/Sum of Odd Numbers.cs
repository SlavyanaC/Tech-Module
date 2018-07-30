using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentNum = 1;
            int sum = 0;

            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine(currentNum);
                sum += currentNum;
                currentNum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
