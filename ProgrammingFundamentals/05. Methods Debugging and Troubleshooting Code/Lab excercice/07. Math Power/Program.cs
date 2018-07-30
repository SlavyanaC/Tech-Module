using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(input, power));
        }

        static double RaiseToPower(double input, double power)
        {
            return Math.Pow(input, power);
        }
    }
}
