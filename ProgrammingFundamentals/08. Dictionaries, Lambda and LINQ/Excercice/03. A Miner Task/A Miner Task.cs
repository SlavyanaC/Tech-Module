using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var mineResources = new Dictionary<string, int>();
            bool continueReading = true;
            while (continueReading)
            {
                var resource = Console.ReadLine();
                var quantity = 0;

                if (resource == "stop")
                {
                    continueReading = false;
                    PrintSortedDict(mineResources);
                    break;
                }
                else
                {
                    quantity = int.Parse(Console.ReadLine());
                }

                if (mineResources.ContainsKey(resource))
                {
                    mineResources[resource] += quantity;
                }
                else
                {
                    mineResources.Add(resource, quantity);
                }
            }
        }

        static void PrintSortedDict(Dictionary<string, int> mineResources)
        {
            foreach (KeyValuePair<string, int> resource in mineResources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
