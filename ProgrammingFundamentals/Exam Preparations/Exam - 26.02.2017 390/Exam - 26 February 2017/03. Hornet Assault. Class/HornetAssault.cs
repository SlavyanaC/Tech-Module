using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault.Class
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> aliveBehives = new List<long>();
            foreach (var beehive in beehives)
            {
                if (hornets.Count == 0)
                {
                    aliveBehives.Add(beehive);
                    continue;
                }

                var power = hornets.Sum();
                if (power >= beehive)
                {
                    if (power == beehive)
                    {
                        hornets.RemoveAt(0);
                    }
                }
                else
                {
                    aliveBehives.Add(beehive - power);
                    hornets.RemoveAt(0);
                }
            }
            if (aliveBehives.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aliveBehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
