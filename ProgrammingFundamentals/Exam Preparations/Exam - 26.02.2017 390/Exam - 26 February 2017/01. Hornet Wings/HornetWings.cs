using System;
using System.Numerics;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = BigInteger.Parse(Console.ReadLine());
            var distanceThausendFlaps = decimal.Parse(Console.ReadLine());
            var endurance = BigInteger.Parse(Console.ReadLine());

            var distance = (decimal)(wingFlaps / 1000) * distanceThausendFlaps;
            var flapsPerSecond = 100;
            var seconds = wingFlaps / flapsPerSecond;
            var breakSeconds = (wingFlaps / endurance) * 5;
            var totalSeconds = seconds + breakSeconds;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
