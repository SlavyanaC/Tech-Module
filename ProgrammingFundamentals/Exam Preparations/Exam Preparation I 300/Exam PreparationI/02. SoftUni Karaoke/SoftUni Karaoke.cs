using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> songs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, List<string>> awardedParticipants = new Dictionary<string, List<string>>();
            bool canContinue = true;
            while (canContinue)
            {
                var command = Console.ReadLine();
                if (command == "dawn")
                {
                    canContinue = false;
                    break;
                }
                var commandArgs = command.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var participant = commandArgs[0];
                var song = commandArgs[1];
                var award = commandArgs[2];

                if ((participant.Contains(participant)) && (songs.Contains(song)))
                {
                    if (!awardedParticipants.ContainsKey(participant))
                    {
                        awardedParticipants.Add(participant, new List<string>());
                    }
                    if (!awardedParticipants[participant].Contains(award))
                    {
                        awardedParticipants[participant].Add(award);
                    }
                }
            }

            if (awardedParticipants.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            foreach (var awarded in awardedParticipants.OrderByDescending(p => p.Value.Count))
            {
                Console.WriteLine($"{awarded.Key}: {awarded.Value.Count} awards");
                foreach (var award in awarded.Value.OrderBy(p => p))
                {
                    Console.WriteLine($"--{String.Join(Environment.NewLine, award)}");
                }
            }
        }
    }
}
