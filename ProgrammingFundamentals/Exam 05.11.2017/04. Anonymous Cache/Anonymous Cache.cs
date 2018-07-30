using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Anonymous_Cache
{
    //100/100
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dataSetsWithDataKeys = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "thetinggoesskrra")
                {
                    break;
                }
                var inputTokens = inputLine.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens.Length == 1)
                {
                    var dataSet = inputTokens[0];
                    if (cache.ContainsKey(dataSet))
                    {
                        dataSetsWithDataKeys.Add(dataSet, new Dictionary<string, long>());
                        foreach (var item in cache[dataSet])
                        {
                            dataSetsWithDataKeys[dataSet].Add(item.Key, item.Value);
                        }
                    }
                    if (!dataSetsWithDataKeys.ContainsKey(dataSet))
                    {
                        dataSetsWithDataKeys.Add(dataSet, new Dictionary<string, long>());
                    }
                }
                else
                {
                    var dataKey = inputTokens[0];
                    var dataSize = long.Parse(inputTokens[1]);
                    var dataSet = inputTokens[2];

                    if (dataSetsWithDataKeys.ContainsKey(dataSet))
                    {
                        dataSetsWithDataKeys[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }
                        cache[dataSet].Add(dataKey, dataSize);
                    }
                }
            }
            if (dataSetsWithDataKeys.Count > 0)
            {
                var hightestDataSet = dataSetsWithDataKeys.OrderByDescending(s => s.Value.Values.Sum()).Take(1).ToDictionary(s => s.Key, s => s.Value);
                foreach (var dataSet in hightestDataSet)
                {
                    Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.Values.Sum()}");

                    foreach (var dataKey in dataSet.Value)
                    {
                        Console.WriteLine($"$.{dataKey.Key}");
                    }
                }
            }
        }
    }
}
