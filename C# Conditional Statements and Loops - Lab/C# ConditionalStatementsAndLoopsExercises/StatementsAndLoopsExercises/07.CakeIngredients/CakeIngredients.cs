using System;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            int count = 0;
            for (int i = 1; i <= 50; i++)
            {
                
                string ingredients = Console.ReadLine();

                

                if (ingredients == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");

                }
                count++;
            }
        }
    }
}
