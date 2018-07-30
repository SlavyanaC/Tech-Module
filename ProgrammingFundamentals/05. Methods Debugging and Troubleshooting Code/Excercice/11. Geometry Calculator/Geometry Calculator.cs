using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0.0;
            switch (figure)
            {
                case "triangle": result = GetAreaTriangle(figure); break;
                case "rectangle": result = GetAreaRectangle(figure); break;
                case "square": result = GetAreaSquare(figure); break;
                case "circle": result = GetAreaCircle(figure) ; break;
            }
            Console.WriteLine($"{result:f2}");
        }

        static double GetAreaTriangle(string figure)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (side * height) / 2;
            return area;
        }

        static double GetAreaRectangle(string figure)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            return area;
        }

        static double GetAreaSquare(string figure)
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            return area;
        }

        static double GetAreaCircle(string figure)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
