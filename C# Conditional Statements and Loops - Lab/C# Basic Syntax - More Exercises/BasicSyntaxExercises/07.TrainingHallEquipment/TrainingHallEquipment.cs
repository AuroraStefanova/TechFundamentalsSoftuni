using System;

namespace _07.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main()
        {
            double budjet = double.Parse(Console.ReadLine());
            int listOfItems = int.Parse(Console.ReadLine());
            double sum = 0;
            double left = 0;

            for (int i = 1; i <= listOfItems; i++)
            {
                string nameItames = Console.ReadLine();
                double priceItame = double.Parse(Console.ReadLine());
                int numbersOfThings = int.Parse(Console.ReadLine());

                if(numbersOfThings != 1)
                {
                    nameItames += "s";

                    Console.WriteLine($"Adding {numbersOfThings} {nameItames} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {numbersOfThings} {nameItames} to cart.");

                }

                sum += priceItame * numbersOfThings;
                
            }
            Console.WriteLine($"Subtotal: ${sum:F2}");
            if(budjet >= sum)
            {
                left = budjet - sum;
                Console.WriteLine($"Money left: ${left:F2}");
            }
            else
            {
                left = sum - budjet;
                Console.WriteLine($"Not enough. We need ${left:F2} more.");
            }
        }
    }
}
