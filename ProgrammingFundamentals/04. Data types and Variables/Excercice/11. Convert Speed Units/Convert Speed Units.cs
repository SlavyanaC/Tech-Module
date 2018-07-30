using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint distance = uint.Parse(Console.ReadLine());                                 
            int hours = int.Parse(Console.ReadLine());      
            int minutes = int.Parse(Console.ReadLine());    
            int seconds = int.Parse(Console.ReadLine());

            decimal timeSeconds = (decimal)((hours * 3600) + (minutes * 60) + seconds); //Става голямо число и с float се губи точност и всичко надолу става грешно
            float metersPerSecs = (float)(distance / timeSeconds); //Трябва да се кастне

            float metersToKm = distance / 1000;
            decimal timeHours = (decimal)(timeSeconds / 3600); //По този начин е по-лесно и не толкова объркващо
            float killometersPerHour = (float)(metersToKm) / (float)(timeHours); //Трябва да се кастне

            float distanceInMiles = distance / 1609f; // Отделна променлива за преобрауването от метри в мили
            float milesPerHour = (float)(distanceInMiles) / (float)(timeHours);

            Console.WriteLine(metersPerSecs);       //Принтират се без закръгляне
            Console.WriteLine(killometersPerHour);  //Принтират се без закръгляне
            Console.WriteLine(milesPerHour);        //Принтират се без закръгляне
        }
    }
}