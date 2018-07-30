using System;

namespace _01.Splinter_Trip
{
    //100/100
    class Program
    {
        static void Main(string[] args)
        {
            decimal tripDistance = decimal.Parse(Console.ReadLine());
            decimal fuelTankCapacity = decimal.Parse(Console.ReadLine());
            decimal milesHeavyWinds = decimal.Parse(Console.ReadLine());

            decimal milesNotHeavyWinds = tripDistance - milesHeavyWinds;
            decimal nonHeavyConsumption = milesNotHeavyWinds * 25m;
            decimal heavyConsumption = milesHeavyWinds * (25m * 1.5m);

            decimal fuelConsumption = nonHeavyConsumption + heavyConsumption;
            decimal totoalFuel = fuelConsumption * 1.05m;

            Console.WriteLine($"Fuel needed: {totoalFuel:F2}L");
            if (totoalFuel <= fuelTankCapacity)
            {
                Console.WriteLine($"Enough with {fuelTankCapacity - totoalFuel:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {totoalFuel - fuelTankCapacity:F2}L more fuel.");
            }
        }
    }
}
