using System;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int totalHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int totalEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', totalHealth-currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', totalEnergy - currentEnergy));
        }
    }
}