using System;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            string gameName = string.Empty;

            double priceGame = 0.0;
            double totalSpend = 0.0;

            while (currentBalance >= 0)
            {
                gameName = Console.ReadLine().ToLower();

                if (gameName == "game time")
                {
                    Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${currentBalance:f2}");
                    break;
                }

                else if (gameName == "outfall 4" || gameName == "cs:ogG" || gameName == "zplinter zell" || 
                         gameName == "honored 2" || gameName == "roverwatch" || gameName == "roverwatch origins edition")
                {
                    switch (gameName)
                    {
                        case "outfall 4":
                        case "roverwatch origins edition": priceGame = 39.99; break;
                        case "cs: og": priceGame = 15.99; break;
                        case "zplinter zell": priceGame = 19.99; break;
                        case "honored 2": priceGame = 59.99; break;
                        case "roverwatch": priceGame = 29.99; break;
                    }

                    if (currentBalance < priceGame)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    else if (currentBalance >= priceGame)
                    {
                        currentBalance -= priceGame;
                        totalSpend += priceGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }

                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}