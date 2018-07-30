using System;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            var price = 0;

            if (dayType == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
            }

            else if (dayType == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }

            else if (dayType == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
            }

            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }

            else 
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
