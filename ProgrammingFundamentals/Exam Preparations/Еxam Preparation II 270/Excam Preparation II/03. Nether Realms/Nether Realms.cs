using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new string[] { ", ", " ", "\r\n", "\t", "," }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, List<double>> demonStats = new SortedDictionary<string, List<double>>();
            foreach (var name in demons)
            {
                var health = 0.0;
                var demage = 0.0;
                var multiplierCount = 0;
                var deviderCount = 0;

                var currentDemon = name;
                List<bool> isMultiplication = new List<bool>();
                foreach (var ch in name)
                {
                    if ((ch >= 65 && ch <= 90)
                        || (ch >= 97 && ch <= 122))
                    {
                        health += (int)ch;
                        currentDemon = currentDemon.Replace(ch, ' ');
                    }
                    else if (ch == '/')
                    {
                        deviderCount++;
                        currentDemon = currentDemon.Replace(ch, ' ');
                        isMultiplication.Add(false);
                    }
                    else if (ch == '*')
                    {
                        multiplierCount++;
                        currentDemon = currentDemon.Replace(ch, ' ');
                        isMultiplication.Add(true);
                    }
                }

                List<double> demonNameDigits = currentDemon.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();
                foreach (var digit in demonNameDigits)
                {
                    demage += digit;
                }

                foreach (var item in isMultiplication)
                {
                    if (item == true)
                    {
                        demage = demage * 2;
                    }
                    else
                    {
                        demage = demage / 2;
                    }
                }
                demonStats[name] = new List<double> { health, demage };
            }

            foreach (var demon in demonStats)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:F2} damage ");
            }
        }
    }
}
