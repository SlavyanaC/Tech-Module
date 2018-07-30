using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face": GetFace(side); break;
                case "space": GetSpace(side); break;
                case "volume": GetVolume(side); break;
                case "area": GetArea(side);  break;
            }
        }

        private static void GetFace(double side)
        {
            Console.WriteLine(Math.Round(Math.Sqrt(2 * side * side), 2));
        }

        private static void GetSpace(double side)
        {
            Console.WriteLine(Math.Round(Math.Sqrt(3 * side * side), 2));
        }

        private static void GetVolume(double side)
        {
            double volume = side * side * side;
            Console.WriteLine($"{volume:f2}");
        }

        private static void GetArea(double side)
        {
            double area = 6 * side * side;
            Console.WriteLine($"{area:f2}");
        }
    }
}
