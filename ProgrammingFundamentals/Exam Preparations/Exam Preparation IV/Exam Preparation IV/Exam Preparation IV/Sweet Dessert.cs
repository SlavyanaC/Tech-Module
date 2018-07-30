using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal priceBanana = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal pricePerKgBerries = decimal.Parse(Console.ReadLine());

            long portionsNeeded = 0;
            if (guests % 6 == 0)
            {
                portionsNeeded = guests / 6;
            }
            else
            {
                portionsNeeded = guests / 6 + 1;
            }

            decimal moneyNeeded = 0.0m;
            moneyNeeded = (portionsNeeded * 2 * priceBanana) + (portionsNeeded * 4 * priceEgg) + (portionsNeeded * 0.2m * pricePerKgBerries);
            if (moneyNeeded <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                var moneyToDraw = moneyNeeded - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyToDraw:F2}lv more.");
            }

        }
    }
}
