using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celcius = ConvertToCelcius(fahrenheit);
            Console.WriteLine($"{celcius:f2}");
        }

        static double ConvertToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
