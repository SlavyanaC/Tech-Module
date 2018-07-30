﻿using System;

namespace P05_BPM_Counter
{
    class P05_BPM_Counter
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = int.Parse(Console.ReadLine());
            int beatsCount = int.Parse(Console.ReadLine());

            double bars = Math.Round(beatsCount / 4.0, 1);
            int durationInSeconds = (int)((beatsCount / beatsPerMinute) * 60);
            int durationMinutes = durationInSeconds / 60;
            durationInSeconds %= 60;

            Console.WriteLine($"{bars} bars - {durationMinutes}m {durationInSeconds}s");
        }
    }
}