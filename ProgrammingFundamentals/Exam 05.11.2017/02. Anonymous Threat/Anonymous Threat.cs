using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Anonymous_Threat
{
    //100/100
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "3:1")
                {
                    break;
                }
                var commandTokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandTokens[0] == "merge")
                {
                    var startIndex = int.Parse(commandTokens[1]);
                    var endIndex = int.Parse(commandTokens[2]);
                    if (startIndex > sequence.Count - 1 && endIndex > sequence.Count - 1)
                    {
                        continue;
                    }
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > sequence.Count - 1 || endIndex < 0)
                    {
                        endIndex = sequence.Count - 1;
                    }
                    var itemsToRemoveCount = 0;
                    StringBuilder newToken = new StringBuilder();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newToken.Append(sequence[i]);
                        itemsToRemoveCount++;
                    }

                    sequence.RemoveRange(startIndex, itemsToRemoveCount);
                    sequence.Insert(startIndex, newToken.ToString());
                }
                else if (commandTokens[0] == "divide")
                {
                    var index = int.Parse(commandTokens[1]);
                    var parts = int.Parse(commandTokens[2]);

                    string elementToDivide = sequence[index];
                    var elementsPerPart = elementToDivide.Length / parts;
                    var elementsLeft = elementToDivide.Length % parts;
                    sequence.RemoveAt(index);
                    List<string> dividedItems = new List<string>();
                    if (elementsLeft == 0)
                    {
                        for (int i = 0; i <= elementToDivide.Length - elementsPerPart; i += elementsPerPart)
                        {
                            var elementToAdd = elementToDivide.Substring(i, elementsPerPart);
                            dividedItems.Add(elementToAdd);
                        }
                    }
                    else if (elementsLeft > 0)
                    {
                        for (int i = 0; i < elementToDivide.Length - elementsPerPart - elementsLeft; i += elementsPerPart)
                        {
                            var elementToAdd = elementToDivide.Substring(i, elementsPerPart);
                            dividedItems.Add(elementToAdd);
                        }
                        string leftElements = elementToDivide.Substring((parts - 1) * elementsPerPart);
                        dividedItems.Add(leftElements);
                    }
                    sequence.InsertRange(index, dividedItems);
                }
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}