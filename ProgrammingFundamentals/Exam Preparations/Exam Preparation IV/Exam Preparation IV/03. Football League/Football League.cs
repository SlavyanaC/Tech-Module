using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            Dictionary<string, int> teamWithPoints = new Dictionary<string, int>();
            Dictionary<string, int> teamWithGoals = new Dictionary<string, int>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "final")
                {
                    break;
                }
                var inputLineTokens = inputLine.Split();
                var firstTeam = GetTeam(inputLineTokens[0], key);
                var secondTeam = GetTeam(inputLineTokens[1], key);

                var score = inputLineTokens[2];
                var goalsFirstTeam = score.Split(':').Select(int.Parse).First();
                var goalsSecondTeam = score.Split(':').Select(int.Parse).Last();

                if (!teamWithGoals.ContainsKey(firstTeam))
                {
                    teamWithGoals[firstTeam] = 0;
                    teamWithPoints[firstTeam] = 0;
                }
                if (!teamWithGoals.ContainsKey(secondTeam))
                {
                    teamWithGoals[secondTeam] = 0;
                    teamWithPoints[secondTeam] = 0;
                }

                teamWithGoals[firstTeam] += goalsFirstTeam;
                teamWithGoals[secondTeam] += goalsSecondTeam;

                if (goalsFirstTeam > goalsSecondTeam)
                {
                    teamWithPoints[firstTeam] += 3;
                }
                else if (goalsSecondTeam > goalsFirstTeam)
                {
                    teamWithPoints[secondTeam] += 3;
                }
                else
                {
                    teamWithPoints[firstTeam] += 1;
                    teamWithPoints[secondTeam] += 1;
                }
            }

            Console.WriteLine("League standings:");
            var position = 0;
            foreach (var team in teamWithPoints.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{++position}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");

            teamWithGoals = teamWithGoals.OrderByDescending(t => t.Value)
                .ThenBy(t => t.Key)
                .Take(3)
                .ToDictionary(t => t.Key, t => t.Value);
            foreach (var team in teamWithGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        static string GetTeam(string currentTeam, string key)
        {
            int startIndex = currentTeam.IndexOf(key) + key.Length;
            int lastIndex = currentTeam.LastIndexOf(key);

            var team = currentTeam.Substring(startIndex, lastIndex - startIndex).ToUpper();
            return new string(team.Reverse().ToArray());
        }
    }
}
