using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int firstNum = n; firstNum >= 1; firstNum--)
            {
                for (int secontNum = 1; secontNum <= m; secontNum++)
                {
                   if (sum >= boundary)
                    {
                        break;
                    }
                    sum += 3 * (firstNum * secontNum);
                    counter++;
                }
            }
            Console.WriteLine($"{counter} combinations");

            if (sum >= boundary)
            {
                Console.WriteLine($"Sum: {sum} >= {boundary}");
            }
            if (sum < boundary)
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
