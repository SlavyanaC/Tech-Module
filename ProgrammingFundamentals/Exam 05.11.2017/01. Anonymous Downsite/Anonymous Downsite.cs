using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        //100/100
        static void Main(string[] args)
        {
            int sitesDown = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            List<string> affectedWebsites = new List<string>();
            decimal totalLoss = 0.0m;
            for (int i = 0; i < sitesDown; i++)
            {
                string[] inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string siteName = inputLine[0];
                ulong siteVisits = ulong.Parse(inputLine[1]);
                decimal pricePerVisit = decimal.Parse(inputLine[2]);
                affectedWebsites.Add(siteName);
                totalLoss += pricePerVisit * siteVisits;
            }

            foreach (var site in affectedWebsites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");

            BigInteger securityToken = BigInteger.Pow(securityKey, sitesDown);
            Console.WriteLine($"Security Token: {securityToken:f0}");
        }
    }
}