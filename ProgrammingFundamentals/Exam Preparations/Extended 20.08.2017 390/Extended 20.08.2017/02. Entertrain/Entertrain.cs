using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Entertrain
{
    //100/100
    class Entertrain
    {
        static void Main(string[] args)
        {
            int locomotivPower = int.Parse(Console.ReadLine());
            List<int> totalWeight = new List<int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "All ofboard!")
                {
                    break;
                }
                int wagonWeight = int.Parse(command);
                totalWeight.Add(wagonWeight);
                int average = (int)totalWeight.Average();
                var sum = totalWeight.Sum();

                if (sum > locomotivPower)
                {
                    int minDistance = int.MaxValue;
                    var indexToRemove = 0;
                    foreach (var wagon in totalWeight)
                    {
                        var distance = Math.Abs(wagon - average);
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            indexToRemove = totalWeight.IndexOf(wagon);
                        }
                    }
                    totalWeight.RemoveAt(indexToRemove);
                }
            }
            var result = new List<int>();
            for (int i = totalWeight.Count - 1; i >= 0; i--)
            {
                result.Add(totalWeight[i]);
            }
            result.Add(locomotivPower);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
