using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> creatures = new Dictionary<string, List<string>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Blaze it!")
                {
                    break;
                }
                var inputTokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var creture = inputTokens[0];
                var squadMate = inputTokens[1];

                if (!creatures.ContainsKey(creture))
                {
                    creatures.Add(creture, new List<string>());
                }
                if (squadMate == creture || creatures[creture].Contains(squadMate))
                {
                    continue;
                }
                creatures[creture].Add(squadMate);
            }

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (var creature in creatures)
            {
                result.Add(creature.Key, new List<string>());

                foreach (var squadMate in creature.Value)
                {
                    if (creatures.ContainsKey(squadMate) && creatures[squadMate].Contains(creature.Key))
                    {
                        continue;
                    }
                    else
                    {
                        result[creature.Key].Add(squadMate);
                    }
                }
            }

            foreach (var creature in result.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{creature.Key} : {creature.Value.Count}");
            }
        }
    }
}
