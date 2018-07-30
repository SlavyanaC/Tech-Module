using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long totalRrunners = long.Parse(Console.ReadLine());
            long avvLaps = long.Parse(Console.ReadLine());
            long lapLenght = long.Parse(Console.ReadLine());
            long capacity = long.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long totalCapacity = capacity * days;
            double moneyRaised = 0.0;
            if (totalCapacity >= totalRrunners)
            {
                long totalMeters = totalRrunners * avvLaps * lapLenght;
                long totalKm = totalMeters / 1000;
                moneyRaised = totalKm * moneyPerKm;
            }
            else if (totalCapacity < totalRrunners)
            {
                totalRrunners = totalCapacity;
                long totalMeters = totalRrunners * avvLaps * lapLenght;
                long totalKm = totalMeters / 1000;
                moneyRaised = totalKm * moneyPerKm;
            }
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
