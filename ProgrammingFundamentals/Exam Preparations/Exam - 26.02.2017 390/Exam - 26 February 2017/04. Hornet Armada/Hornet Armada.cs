using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionsWithLastActivity = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var activityAndLegion = inputLine[0].Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                var soldierTypeAndCount = inputLine[1].Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = long.Parse(activityAndLegion[0]);
                var legionName = activityAndLegion[1];
                var soldierType = soldierTypeAndCount[0];
                var soldierCount = long.Parse(soldierTypeAndCount[1]);

                if (!legionsWithSoldiers.ContainsKey(legionName))
                {
                    legionsWithSoldiers[legionName] = new Dictionary<string, long>();
                    legionsWithLastActivity[legionName] = lastActivity;
                }
                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName][soldierType] = 0;
                }
                legionsWithSoldiers[legionName][soldierType] += soldierCount;

                if (lastActivity > legionsWithLastActivity[legionName])
                {
                    legionsWithLastActivity[legionName] = lastActivity;
                }
            }

            var commandLine = Console.ReadLine();

            if (commandLine.Contains("\\"))
            {
                var commandLineTokens = commandLine.Split('\\');
                var maxActivity = long.Parse(commandLineTokens[0]);
                var soldierType = commandLineTokens[1];

                var legionsWithLowerActivity = legionsWithSoldiers
                    .Where(x => legionsWithLastActivity[x.Key] < maxActivity)
                    .Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType])
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var legion in legionsWithLowerActivity)
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
                }
            }
            else
            {
                var soldierTypeSearch = commandLine;

                var sortedLegions = legionsWithSoldiers
                    .Where(x => x.Value.ContainsKey(soldierTypeSearch))
                    .OrderByDescending(x => legionsWithLastActivity[x.Key])
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var legion in sortedLegions)
                {
                    Console.WriteLine($"{legionsWithLastActivity[legion.Key]} : {legion.Key}");
                }
            }
        }
    }
}
