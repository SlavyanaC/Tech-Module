using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetArmadaClass
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> legionSoldiers = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> legionActivities = new Dictionary<string, long>();
            var n = long.Parse(Console.ReadLine());
            for (long i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                long activity = long.Parse(inputArgs[0]);
                string legion = inputArgs[1];
                string soldier = inputArgs[2];
                long count = long.Parse(inputArgs[3]);

                if (!legionActivities.ContainsKey(legion))
                {
                    legionActivities.Add(legion, activity);
                }
                else
                {
                    if (activity < legionActivities[legion])
                    {
                        if (!legionSoldiers.ContainsKey(soldier))
                        {
                            legionSoldiers[legion].Add(soldier, count);
                        }
                        else
                        {
                            legionSoldiers[legion][soldier] += count;
                        }
                    }
                    else
                    {
                        legionActivities[legion] = activity;
                    }
                }

                if (!legionSoldiers.ContainsKey(legion))
                {
                    legionSoldiers.Add(legion, new Dictionary<string, long>());
                    legionSoldiers[legion].Add(soldier, 0);
                }
                else
                {
                    if (!legionSoldiers.ContainsKey(soldier))
                    {
                        legionSoldiers[legion].Add(soldier, count);
                    }
                    else
                    {
                        legionSoldiers[legion][soldier] += count;
                    }
                }
            }

            var prlongArgs = Console.ReadLine().Split('\\');

            if (prlongArgs.Length > 1)
            {
                long activity = long.Parse(prlongArgs[0]);
                string soldier = prlongArgs[1];

                foreach (var legion in legionSoldiers
                    .Where(legion => legionActivities[legion.Key] < activity)
                    .OrderByDescending(legion => legion.Value[soldier]))
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value[soldier]}");
                }
            }
            else
            {
                string soldier = prlongArgs[0];
                foreach (var legion in legionActivities
                    .Where(legion => legionSoldiers[legion.Key].ContainsKey(soldier))
                    .OrderByDescending(legion => legionActivities.Values))
                {
                    Console.WriteLine($"{legionActivities[legion.Key]} : {legion.Key}");
                }
            }
        }
    }
}
