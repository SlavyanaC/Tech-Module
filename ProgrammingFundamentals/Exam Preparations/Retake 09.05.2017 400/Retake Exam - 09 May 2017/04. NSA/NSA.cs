using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.NSA
{
    //100/100
    class NSA
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countriesWithSpies = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "quit")
                {
                    break;
                }
                string[] inputTokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string countryName = inputTokens[0];
                string spyName = inputTokens[1];
                var daysInService = long.Parse(inputTokens[2]);

                if (!countriesWithSpies.ContainsKey(countryName))
                {
                    countriesWithSpies.Add(countryName, new Dictionary<string, long>());
                }
                if (!countriesWithSpies[countryName].ContainsKey(spyName))
                {
                    countriesWithSpies[countryName].Add(spyName, daysInService);
                }
                countriesWithSpies[countryName][spyName] = daysInService;
            }

            foreach (var country in countriesWithSpies.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in country.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
