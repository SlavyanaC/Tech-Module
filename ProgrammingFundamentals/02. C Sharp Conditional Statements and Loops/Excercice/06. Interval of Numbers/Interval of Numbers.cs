using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = Math.Min(firstNumber, secondNumber); currentNumber <= Math.Max(firstNumber, secondNumber); currentNumber++)
            {
                Console.WriteLine(currentNumber);
            }
        }
    }
}
