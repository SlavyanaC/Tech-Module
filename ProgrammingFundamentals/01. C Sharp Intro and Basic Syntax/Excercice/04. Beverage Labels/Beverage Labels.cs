using System;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double mililiters = double.Parse(Console.ReadLine());
            double energyPerHundret = double.Parse(Console.ReadLine());
            double sugarPerHundret = double.Parse(Console.ReadLine());

            Console.WriteLine($"{mililiters}ml {name}:");
            Console.WriteLine("{0}kcal, {1}g sugars", mililiters*energyPerHundret/100, mililiters*sugarPerHundret/100);
        }
    }
}
