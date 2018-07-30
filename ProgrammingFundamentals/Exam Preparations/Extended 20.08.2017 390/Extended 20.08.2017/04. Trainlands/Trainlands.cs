using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    //100/100
    class Trainlands
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "It's Training Men!")
                {
                    break;
                }
                var inputTokens = inputLine.Split(' ');
                if (inputTokens.Length == 5) //CREATE TRAIN
                {
                    var trainName = inputTokens[0];
                    var wagonName = inputTokens[2];
                    var wagonPower = int.Parse(inputTokens[4]);
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    trains[trainName].Add(wagonName, wagonPower);
                }
                else
                {
                    if (inputTokens[1] == "->") //ADD OTHER TRAIN TO FIRST TRAIN
                    {
                        var firstTain = inputTokens[0];
                        var otherTrain = inputTokens[2];
                        if (!trains.ContainsKey(firstTain))
                        {
                            trains.Add(firstTain, new Dictionary<string, int>());
                        }
                        foreach (var wagon in trains[otherTrain])
                        {
                            trains[firstTain].Add(wagon.Key, wagon.Value);
                        }
                        trains.Remove(otherTrain);
                    }
                    else if (inputTokens[1] == "=") //CORY OTHER TRAIN TO FIRST TRAIN
                    {
                        var firstTain = inputTokens[0];
                        var otherTrain = inputTokens[2];
                        if (!trains.ContainsKey(firstTain))
                        {
                            trains.Add(firstTain, new Dictionary<string, int>());
                        }
                        trains[firstTain].Clear();
                        foreach (var wagon in trains[otherTrain])
                        {
                            trains[firstTain].Add(wagon.Key, wagon.Value);
                        }
                    }
                }
            }

            trains = trains
                .OrderByDescending(t => t.Value.Values.Sum())
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var train in trains)
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
