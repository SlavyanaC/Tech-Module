using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornest = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornestPower = hornest.Sum();
                if (hornestPower <= beehives[i])
                {
                    hornest.RemoveAt(0);
                }

                if (hornestPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= (long)(hornestPower);
                }

                if (hornest.Count == 0)
                {
                    break;
                }
            }
            if (beehives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornest));
            }
        }
    }

}