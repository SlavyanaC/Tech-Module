using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyItems = new Dictionary<string, int> { ["shards"] = 0, ["fragments"] = 0, ["motes"] = 0, };
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();
            bool continueReadingInput = true;
            while (continueReadingInput)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
                var quantity = 0;
                var material = string.Empty;
                for (int i = 0; i < input.Length; i += 2)
                {
                    quantity = int.Parse(input[i]);
                    material = input[i + 1];
                    if ((material == "shards" || material == "fragments" || material == "motes") && keyItems.ContainsKey(material))
                    {
                        keyItems[material] += quantity;
                        if (keyItems[material] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(material))
                        {
                            junkItems.Add(material, quantity);
                        }
                        else
                        {
                            junkItems[material] += quantity;
                        }
                    }
                }

                string obtainedItem = string.Empty;
                foreach (var item in keyItems)
                {
                    if (item.Value >= 250)
                    {
                        keyItems[item.Key] -= 250;
                        switch (item.Key)
                        {
                            case "shards":
                                obtainedItem = "Shadowmourne";
                                break;
                            case "fragments":
                                obtainedItem = "Valanyr";
                                break;
                            case "motes":
                                obtainedItem = "Dragonwrath";
                                break;
                        }

                        Console.WriteLine($"{obtainedItem} obtained!");
                        continueReadingInput = false;
                        break;
                    }
                }
            }

            foreach (var keyItem in keyItems.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{keyItem.Key}: {keyItem.Value}");
            }

            foreach (var junkItem in junkItems)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }
    }
}