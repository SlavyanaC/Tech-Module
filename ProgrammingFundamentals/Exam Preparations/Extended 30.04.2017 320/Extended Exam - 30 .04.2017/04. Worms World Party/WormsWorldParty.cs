using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Worms_World_Party
{
    //100/100
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> teamsAndScore = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "quit")
                {
                    break;
                }
                var inputTokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var teamName = inputTokens[1];
                var wormName = inputTokens[0];
                var score = long.Parse(inputTokens[2]);
                if (teamsAndScore.Values.Any(w => w.ContainsKey(wormName)))
                {
                    continue;
                }
                if (!teamsAndScore.ContainsKey(teamName))
                {
                    teamsAndScore.Add(teamName, new Dictionary<string, long>());
                }
                teamsAndScore[teamName].Add(wormName, score);
            }

            var position = 1;
            foreach (var team in teamsAndScore
                .OrderByDescending(t => t.Value.Values.Sum())
                .ThenByDescending(t => t.Value.Values.Average()))
            {
                Console.WriteLine($"{position}. Team: {team.Key} - {team.Value.Values.Sum()}");
                foreach (var worm in team.Value.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
                position++;
            }
        }
    }
}
