using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;
            for (int i = 0; i < countOrders; i++)
            {
                decimal price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        static decimal ReadOrderAndCalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var capsuleCount = decimal.Parse(Console.ReadLine());
            decimal price = (daysInMonth * capsuleCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:F2}");
            return price;
        }
    }
}
