using System;


namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            int numberIngredients = int.Parse(Console.ReadLine());
            var cheese = 0;
            var tomatoSauce = 0;
            var salami = 0;
            var pepper = 0;

            for (int i = 1; i <= numberIngredients; i++)
            {
                string ingredients = Console.ReadLine();
                string ingredients1 = ingredients.ToLower();
                if(ingredients1 == "cheese")
                {
                    cheese += 500;
                }
                else if(ingredients1 == "tomato sauce")
                {
                    tomatoSauce += 150;
                }
                else if(ingredients1 == "salami")
                {
                    salami += 600;
                }
                else if(ingredients1 == "pepper")
                {
                    pepper += 50;
                }

            }
            int sum = pepper + salami + tomatoSauce + cheese;
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
