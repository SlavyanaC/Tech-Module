using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    // 90/100
    class Trainers
    {
        static void Main(string[] args)
        {
            ulong participants = ulong.Parse(Console.ReadLine());
            Dictionary<string, decimal> moneyWonByTeem = new Dictionary<string, decimal>();
            for (ulong i = 0; i < participants; i++)
            {
                ulong distanceMiles = ulong.Parse(Console.ReadLine());
                decimal cargoCeriedTons = decimal.Parse(Console.ReadLine());
                string team = Console.ReadLine();
                decimal cargoInKg = cargoCeriedTons * 1000m;
                ulong distanceM = distanceMiles * 1600;
                decimal earnedMoney = (cargoInKg * 1.5m) - (0.7m * distanceM * 2.5m);
                if (!moneyWonByTeem.ContainsKey(team))
                {
                    moneyWonByTeem.Add(team, 0);
                }
                moneyWonByTeem[team] += earnedMoney;
            }

            moneyWonByTeem = moneyWonByTeem.OrderByDescending(t => t.Value)
                .Take(1)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var team in moneyWonByTeem)
            {
                Console.WriteLine($"The {team.Key} Trainers win with ${team.Value:f3}.");
            }
        }
    }
}
