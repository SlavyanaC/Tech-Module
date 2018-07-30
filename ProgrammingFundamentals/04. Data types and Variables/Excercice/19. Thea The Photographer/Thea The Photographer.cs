using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong totalPictures = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine()); 
            double filterFactor = double.Parse(Console.ReadLine());
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling((double)(filterFactor / 100) * (double)totalPictures);
            ulong totalFilterTime = filterTime * totalPictures;
            ulong totalUploadTime = (ulong)filteredPictures * uploadTime;

            ulong totalTime = totalFilterTime + totalUploadTime;

            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}", t.Days, t.Hours, t.Minutes, t.Seconds);
            Console.WriteLine(answer);
        }
    }
}
