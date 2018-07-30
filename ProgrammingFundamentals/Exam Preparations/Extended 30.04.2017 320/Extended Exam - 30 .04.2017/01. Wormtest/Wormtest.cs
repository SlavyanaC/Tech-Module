using System;

namespace _01.Wormtest
{
    /100/100
    class Wormtest
    {
        static void Main(string[] args)
        {
            long wormLenght = long.Parse(Console.ReadLine());
            long lenghtCm = wormLenght * 100;
            decimal wormWidthCm = decimal.Parse(Console.ReadLine());
            if (wormWidthCm != 0.0m)
            {
                long reminder = (long)(lenghtCm % wormWidthCm);
                if (reminder == 0)
                {
                    var result = lenghtCm * wormWidthCm;
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    var result = (lenghtCm / wormWidthCm) * 100;
                    Console.WriteLine($"{result:F2}%");
                }
            }
            else
            {
                var result = lenghtCm * wormWidthCm;
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}
