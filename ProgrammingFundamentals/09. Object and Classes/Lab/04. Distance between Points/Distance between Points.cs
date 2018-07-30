using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointArgs = Console.ReadLine()
                .Split(' ');
            var secondPointArgs = Console.ReadLine()
                .Split(' ');

            Point firstPoint = new Point
            {
                X = double.Parse(firstPointArgs[0]),
                Y = double.Parse(firstPointArgs[1]),
            };

            Point secondPoint = new Point
            {
                X = double.Parse(secondPointArgs[0]),
                Y = double.Parse(secondPointArgs[1]),
            };
            var result = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(
                Math.Pow((secondPoint.X - firstPoint.X), 2) +
                Math.Pow((secondPoint.Y - firstPoint.Y), 2));
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
