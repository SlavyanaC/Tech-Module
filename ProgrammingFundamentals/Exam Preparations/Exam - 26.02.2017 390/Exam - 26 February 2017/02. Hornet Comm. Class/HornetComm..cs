using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Hornet_Comm.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Hornet is Green")
                {
                    break;
                }
                var inputTokens = inputLine.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens.Length != 2)
                {
                    continue;
                }

                if (inputTokens[0].ToCharArray().All(ch => char.IsDigit(ch) &&
                inputTokens[1].ToCharArray().All(c => char.IsLetterOrDigit(c))))
                {
                    messages.Add($"{string.Join("", inputTokens[0].ToCharArray().Reverse())} -> {inputTokens[1]}");
                }
                if (!inputTokens[0].ToCharArray().Any(ch => char.IsDigit(ch)) &&
                    inputTokens[1].ToCharArray().All(c => char.IsLetterOrDigit(c)))
                {
                    StringBuilder frequancy = new StringBuilder();
                    foreach (var ch in inputTokens[1].ToCharArray())
                    {
                        if (char.IsLower(ch))
                        {
                            frequancy.Append(char.ToUpper(ch));
                        }
                        else if (char.IsUpper(ch))
                        {
                            frequancy.Append(char.ToLower(ch));
                        }
                        else
                        {
                            frequancy.Append(ch);
                        }

                    }

                    broadcasts.Add($"{frequancy.ToString()} -> {inputTokens[0]}");
                }
            }

            PrintResult(broadcasts, messages);
        }

        static void PrintResult(List<string> broadcasts, List<string> messages)
        {
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var br in broadcasts)
                {
                    Console.WriteLine($"{br}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var ms in messages)
                {
                    Console.WriteLine($"{ms}");
                }
            }
        }
    }
}
