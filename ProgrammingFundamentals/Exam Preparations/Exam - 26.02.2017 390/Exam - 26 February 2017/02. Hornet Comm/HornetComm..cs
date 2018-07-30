using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string patternMessage = @"(^\d+)\s<->\s([A-Za-z0-9]+)$";
            string patternBroadcast = @"(^\D+)\s<->\s([A-Za-z0-9]+)$";

            Regex broadCastsRegex = new Regex(patternBroadcast);
            Regex massageRegex = new Regex(patternMessage);

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Hornet is Green")
                {
                    break;
                }

                if (massageRegex.IsMatch(inputLine))
                {
                    var match = massageRegex.Match(inputLine);
                    var firstQuery = match.Groups[1].Value;
                    var massage = match.Groups[2].Value;
                    ProcessPrivatMessages(messages, firstQuery, massage);
                }
                else if (broadCastsRegex.IsMatch(inputLine))
                {
                    var match = broadCastsRegex.Match(inputLine);
                    var firstQuery = match.Groups[1].Value;
                    var secondQuery = match.Groups[2].Value;
                    ProcessBroadcastMessages(broadcasts, firstQuery, secondQuery);
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count <= 0)
                Console.WriteLine("None");
            else
            {
                for (int i = 1; i < broadcasts.Count; i += 2)
                {
                    Console.WriteLine($"{broadcasts[i - 1]} -> {broadcasts[i]}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count <= 0)
                Console.WriteLine("None");
            else
            {
                for (int i = 1; i < messages.Count; i += 2)
                {
                    Console.WriteLine($"{messages[i - 1]} -> {messages[i]}");
                }
            }
        }

        static void ProcessPrivatMessages(List<string> messages, string firstQuery, string secondQuery)
        {
            var recipient = new string(firstQuery.ToArray().Reverse().ToArray());
            var message = secondQuery;

            messages.Add(recipient);
            messages.Add(message);
        }

        static void ProcessBroadcastMessages(List<string> broadcasts, string firstQuery, string secondQuery)
        {
            string message = firstQuery;
            string frequancy = secondQuery;

            StringBuilder newFrequancy = new StringBuilder();
            foreach (var ch in frequancy)
            {
                if (char.IsLetter(ch))
                {
                    if (char.IsUpper(ch))
                    {
                        newFrequancy.Append(char.ToLower(ch));
                    }
                    else
                    {
                        newFrequancy.Append(char.ToUpper(ch));
                    }
                }
                else
                {
                    newFrequancy.Append(ch);
                }
            }

            broadcasts.Add(newFrequancy.ToString());
            broadcasts.Add(message);
        }
    }
}