using System;

namespace _02.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;

            double sum = 0;

            if (profession == "Athlete")
            {
                sum = water * quantity;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else if ((profession == "Businessman") || (profession == "Businesswoman"))
            {
                sum = quantity * coffee;

                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                sum = quantity * beer;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else
            {
                sum = quantity * tea;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
        }
    }
}
