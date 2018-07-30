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
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>(0);
            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                var currentPoint = new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1],
                };
                points.Add(currentPoint);
            }

            var minDistanceSoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;
            for (int i = 0; i < points.Count-1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistanceSoFar:f3}");
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
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
