using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                var commandTokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string manipulation = commandTokens[0];
                switch (manipulation)
                {
                    case "exchange":
                        var index = int.Parse(commandTokens[1]);
                        if (index >= inputArray.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            var firstArray = new List<long>();
                            var secondArray = new List<long>();

                            for (int i = 0; i <= index; i++)
                            {
                                firstArray.Add(inputArray[i]);
                            }
                            for (int i = index + 1; i < inputArray.Count; i++)
                            {
                                secondArray.Add(inputArray[i]);
                            }
                            inputArray.Clear();
                            inputArray = secondArray.Concat(firstArray).ToList();
                        }
                        break;
                    case "max":
                        GetIndexOfMaxElement(commandTokens, inputArray);
                        break;
                    case "min":
                        GetIndexOfMinElement(commandTokens, inputArray);
                        break;
                    case "first":
                        var count = int.Parse(commandTokens[1]);
                        if (count > inputArray.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            GetFirstCountElements(commandTokens, inputArray, count);
                        }
                        break;
                    case "last":
                        var countt = int.Parse(commandTokens[1]);
                        if (countt > inputArray.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            GetLastCountElements(commandTokens, inputArray, countt);
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        static void GetIndexOfMaxElement(string[] commandTokens, List<long> inputArray)
        {
            if (commandTokens[1] == "even")
            {
                var evenElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 0)
                    {
                        evenElements.Add(element);
                    }
                }
                if (evenElements.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxEven = evenElements.Max();
                    var maxEvenIndex = inputArray.IndexOf(maxEven);
                    Console.WriteLine(maxEvenIndex);
                }
            }
            else
            {
                var oddElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 1)
                    {
                        oddElements.Add(element);
                    }
                }
                if (oddElements.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxOdd = oddElements.Max();
                    var maxOddIndex = inputArray.IndexOf(maxOdd);
                    Console.WriteLine(maxOddIndex);
                }
            }
        }

        static void GetIndexOfMinElement(string[] commandTokens, List<long> inputArray)
        {
            if (commandTokens[1] == "even")
            {
                var evenElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 0)
                    {
                        evenElements.Add(element);
                    }
                }
                if (evenElements.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var minEven = evenElements.Min();
                    var minEvenIndex = inputArray.IndexOf(minEven);
                    Console.WriteLine(minEvenIndex);
                }
            }
            else
            {
                var oddElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 1)
                    {
                        oddElements.Add(element);
                    }
                }
                if (oddElements.Count == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var minOdd = oddElements.Min();
                    var minOddIndex = inputArray.IndexOf(minOdd);
                    Console.WriteLine(minOddIndex);
                }
            }
        }

        static void GetFirstCountElements(string[] commandTokens, List<long> inputArray, int count)
        {
            if (commandTokens[2] == "even")
            {
                var evenElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 0)
                    {
                        evenElements.Add(element);
                    }
                }
                if (evenElements.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var firstCountElements = new List<long>();
                    for (int i = 0; i < Math.Min(count, evenElements.Count); i++)
                    {
                        firstCountElements.Add(evenElements[i]);
                    }
                    Console.WriteLine($"[{string.Join(", ", firstCountElements)}]");
                }
            }
            else
            {
                var oddElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 1)
                    {
                        oddElements.Add(element);
                    }
                }
                if (oddElements.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var firstCountElements = new List<long>();
                    for (int i = 0; i < Math.Min(count, oddElements.Count); i++)
                    {
                        firstCountElements.Add(oddElements[i]);
                    }
                    Console.WriteLine($"[{string.Join(", ", firstCountElements)}]");
                }
            }
        }

        static void GetLastCountElements(string[] commandTokens, List<long> inputArray, int countt)
        {
            if (commandTokens[2] == "even")
            {
                var evenElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 0)
                    {
                        evenElements.Add(element);
                    }
                }
                if (evenElements.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var lastCountElements = new List<long>();
                    for (int i = evenElements.Count - 1; i >= 01; i--)
                    {
                        lastCountElements.Add(evenElements[i]);
                        if (lastCountElements.Count == countt)
                        {
                            lastCountElements.Reverse();
                            Console.WriteLine($"[{string.Join(", ", lastCountElements)}]");
                        }
                    }
                    if (lastCountElements.Count < countt)
                    {
                        lastCountElements.Reverse();
                        Console.WriteLine($"[{string.Join(", ", lastCountElements)}]");
                    }
                }
            }
            else
            {
                var oddElements = new List<long>();
                foreach (var element in inputArray)
                {
                    if (element % 2 == 1)
                    {
                        oddElements.Add(element);
                    }
                }
                if (oddElements.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var lastCountElements = new List<long>();
                    for (int i = oddElements.Count - 1; i >= 0; i--)
                    {
                        lastCountElements.Add(oddElements[i]);
                        if (lastCountElements.Count == countt)
                        {
                            lastCountElements.Reverse();
                            Console.WriteLine($"[{string.Join(", ", lastCountElements)}]");
                            break;
                        }
                    }
                    if (lastCountElements.Count < countt)
                    {
                        lastCountElements.Reverse();
                        Console.WriteLine($"[{string.Join(", ", lastCountElements)}]");
                    }
                }
            }
        }
    }
}
