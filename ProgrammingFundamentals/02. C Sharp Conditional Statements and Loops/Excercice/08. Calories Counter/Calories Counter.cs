using System;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberIngredients = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int currIngredient = 0; currIngredient < numberIngredients; currIngredient++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese": calories += 500; break;
                    case "tomato sauce": calories += 150; break;
                    case "salami": calories += 600; break;
                    case "pepper": calories += 50; break;
                    default: break;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
