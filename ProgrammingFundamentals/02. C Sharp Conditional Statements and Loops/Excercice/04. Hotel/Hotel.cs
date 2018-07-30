using System;

public class Hotel
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        double studioPrice = 0.0;
        double doublePrice = 0.0;
        double suitePrice = 0.0;

        switch (month)
        {
            case "May":
            case "October": studioPrice = 50; doublePrice = 65; suitePrice = 75; break;
            case "June":
            case "September": studioPrice = 60; doublePrice = 72; suitePrice = 82; break;
            case "July":
            case "August":
            case "December": studioPrice = 68; doublePrice = 77; suitePrice = 89; break;
        }

        if ((month == "May" || month == "October") && nightsCount > 7)
        {
            studioPrice *= 0.95;
        }

        if ((month == "June" || month == "September") && nightsCount > 14)
        {
            doublePrice *= 0.9;
        }

        if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
        {
            suitePrice *= 0.85;
        }

        double totalStudioPrice = studioPrice * nightsCount;

        if ((month == "September" || month == "October") && nightsCount > 7)
        {
            totalStudioPrice = studioPrice * (nightsCount - 1);
        }

        double totalDoublePrice = doublePrice * nightsCount;
        double totalSuitePrice = suitePrice * nightsCount;

        Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
        Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
    }
}