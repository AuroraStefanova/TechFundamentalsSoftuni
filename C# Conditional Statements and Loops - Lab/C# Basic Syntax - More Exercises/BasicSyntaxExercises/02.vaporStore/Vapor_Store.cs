using System;
namespace VaporStore
{
    class VaporStore
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            var balance = budget;
            var gameName = Console.ReadLine();

            while (gameName != "Game Time")
            {
                var gamePrice = 0.0;
                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (gamePrice != 0)
                {
                    if (balance < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else if (balance >= gamePrice)
                    {
                        Console.WriteLine("Bought " + gameName);
                        balance -= gamePrice;
                    }
                }

                else if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                gameName = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${budget - balance:F2}. Remaining: ${balance:F2}");
        }
    }
}
