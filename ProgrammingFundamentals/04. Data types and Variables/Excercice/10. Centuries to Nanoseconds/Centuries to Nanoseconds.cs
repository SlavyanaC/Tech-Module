using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(days * 24);
            long minutes = (long)(hours * 60);
            ulong seconds = (ulong)(minutes * 60);
            ulong miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds " +
                             $"= {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
