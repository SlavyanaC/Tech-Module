using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircleData = Console.ReadLine()
                .Split(' ');
            var secondCircleData = Console.ReadLine()
                .Split(' ');
            var firstCircle = new Circle
            {
                X = double.Parse(firstCircleData[0]),
                Y = double.Parse(firstCircleData[1]),
                Radius = double.Parse(firstCircleData[2]),
            };
            var secondCircle = new Circle
            {
                X = double.Parse(secondCircleData[0]),
                Y = double.Parse(secondCircleData[1]),
                Radius = double.Parse(secondCircleData[2]),
            };

            if (Intersect(firstCircle, secondCircle) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var distance = Math.Sqrt(
                Math.Pow((firstCircle.X - secondCircle.X), 2) +
                Math.Pow((firstCircle.Y - secondCircle.Y), 2));
            if (distance <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            return false;
        }
    }

    public class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
}
