using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= num; currentNum++)
            {
                bool primary = true;

                for (int devider = 2; devider <= Math.Sqrt(currentNum); devider++)
                {
                    if (currentNum % devider == 0)
                    {
                        primary = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {primary}");
            }
        }
    }
}
