using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(' ').ToArray();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpointIndex = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var driver in drivers)
            {
                double fuel = (double)driver[0];
                var checkpointCount = 0;
                for (int i = 0; i < zones.Length; i++)
                {
                    bool indexIsEquel = false;
                    for (int j = 0; j < checkpointIndex.Length; j++)
                    {
                        if (i == checkpointIndex[j])
                        {
                            indexIsEquel = true;
                            break;
                        }
                    }
                    if (indexIsEquel)
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel > 0)
                    {
                        checkpointCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{driver} - reached {checkpointCount}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
            }
        }
    }
}

