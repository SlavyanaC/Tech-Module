using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = "";
            double priceHall = 0.0;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            else if (groupSize <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                priceHall = 5000;
            }
            else if (groupSize >= 100)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }

            double pricePackage = 0.0;
            double discount = 0.0;

            switch (package)
            {
                case "Normal": pricePackage = 500; discount = 0.95; break;
                case "Gold": pricePackage = 750; discount = 0.9; break;
                case "Platinum": pricePackage = 1000; discount = 0.85; break;
            }

            double totalPrice = ((priceHall + pricePackage) * discount) / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {totalPrice:F2}$");
        }
    }
}
