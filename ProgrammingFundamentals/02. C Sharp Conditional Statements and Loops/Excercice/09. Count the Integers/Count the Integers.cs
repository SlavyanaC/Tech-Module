using System;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int integersCount = 0;

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    integersCount++;
                }
                catch (Exception)
                {
                    Console.WriteLine(integersCount);
                    break;
                }
            }
        }
    }
}
