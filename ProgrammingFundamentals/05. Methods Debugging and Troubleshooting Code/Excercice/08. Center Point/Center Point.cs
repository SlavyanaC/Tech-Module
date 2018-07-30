using System;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            if (PointOneIsCloserToCenter(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
         }

        private static bool PointOneIsCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distanceFistPont = CalculateDistanceBetweenPointAndCenter(x1, y1, 0, 0);
            double distanceSecondPont = CalculateDistanceBetweenPointAndCenter(x2, y2, 0, 0);
            if (distanceFistPont < distanceSecondPont)
            {
                return true;
            }
            return false;
        }

        private static double CalculateDistanceBetweenPointAndCenter(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}


