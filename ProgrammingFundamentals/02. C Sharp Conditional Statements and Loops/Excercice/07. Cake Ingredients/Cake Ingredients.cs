using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = 0;
            while (true)
            {
                string ingredient = Console.ReadLine();
                
                if (ingredient != "Bake!")
                {
                    numberOfIngredients++;
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
                    break;
                }
            }
        }
    }
}
