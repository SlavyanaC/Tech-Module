using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateArea(widht, height);
            Console.WriteLine(area);

        }

        static double CalculateArea(double widht, double height)
        {
            return widht * height / 2;
        }
    }
}
