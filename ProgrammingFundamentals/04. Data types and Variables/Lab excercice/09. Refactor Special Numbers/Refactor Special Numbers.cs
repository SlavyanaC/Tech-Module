using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNum = 0;

            bool special = false;

            for (int num = 1; num <= n; num++)
            {
                currentNum = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {special}");
                sum = 0;
                num = currentNum;
            }

        }
    }
}
