using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                var commandLine = Console.ReadLine();
                var isValid = true;
                if (commandLine == "end")
                {
                    break;
                }
                ProcessCommand(items, commandLine);
            }
            Console.WriteLine($"[{string.Join(", ", items)}]");
        }

        private static void ProcessCommand(List<string> items, string commandLine)
        {
            var commandTokens = commandLine.Split(' ');
            var commandName = commandTokens[0];
            switch (commandName)
            {
                case "reverse":
                    ReverseList(items, commandTokens);
                    break;
                case "sort":
                    SortList(items, commandTokens);
                    break;
                case "rollLeft":
                    RollLeftList(items, commandTokens);
                    break;
                case "rollRight":
                    RollRightList(items, commandTokens);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

        static void ReverseList(List<string> items, string[] commandTokens)
        {
            var startIndex = int.Parse(commandTokens[2]);
            var count = int.Parse(commandTokens[4]);
            List<string> itemsToReverse = new List<string>();
            for (int i = startIndex; i <= count + 1; i++)
            {
                itemsToReverse.Add(items[i]);
            }
            items.RemoveRange(startIndex, count);
            itemsToReverse.Reverse();
            items.InsertRange(startIndex, itemsToReverse);
        }

        static void SortList(List<string> items, string[] commandTokens)
        {
            var startIndex = int.Parse(commandTokens[2]);
            var count = int.Parse(commandTokens[4]);
            List<string> itemsToReverse = new List<string>();
            for (int i = startIndex; i <= count + 1; i++)
            {
                itemsToReverse.Add(items[i]);
            }
            items.RemoveRange(startIndex, count);
            itemsToReverse.Sort();
            items.InsertRange(startIndex, itemsToReverse);
        }

        static void RollLeftList(List<string> items, string[] commandTokens)
        {
            var count = int.Parse(commandTokens[1]);
            for (int i = 0; i < count; i++)
            {
                var reminder = items.First();
                items.RemoveAt(0);
                items.Add(reminder);
            }
        }

        static void RollRightList(List<string> items, string[] commandTokens)
        {
            var count = int.Parse(commandTokens[1]);
            for (int i = 0; i < count; i++)
            {
                var reminder = items.Last();
                items.RemoveAt(items.Count - 1);
                items.Insert(0, reminder);
            }
        }

        static bool IsValidRange(List<string> items, int startIndex, int count)
        {
            if (startIndex < 0 || count < 0 || startIndex + count - 1 >=  items.Count)
            {
                return false;
            }
            return true;
        }
    }
}
