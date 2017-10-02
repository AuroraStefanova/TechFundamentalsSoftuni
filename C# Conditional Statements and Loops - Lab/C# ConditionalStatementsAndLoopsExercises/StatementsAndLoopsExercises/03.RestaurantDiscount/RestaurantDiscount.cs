using System;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double pricePerPerson = 0;
            double discount = 0;
            double sum = 0;


            
            if(countOfPeople <= 50)//Small Hall 2500$
            {
                if(package == "Normal")
                {
                    sum = (2500 + 500);
                    discount = (sum * 5) / 100;
                    pricePerPerson = (sum - discount)/ countOfPeople;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                if(package == "Gold")
                {
                    sum = (2500 + 750);
                    discount = (sum * 10) / 100;
                    pricePerPerson = (sum - discount)/countOfPeople;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                if(package == "Platinum")
                {
                    sum = (2500 + 1000);
                    discount = (sum * 15) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if((countOfPeople > 50)&&(countOfPeople <= 100))//Terrace 5000$ 
            {
                if (package == "Normal")
                {
                    sum = (5000 + 500);
                    discount = (sum * 5) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                if (package == "Gold")
                {
                    sum = (5000 + 750);
                    discount = (sum * 10) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                if (package == "Platinum")
                {
                    sum = (5000 + 1000);
                    discount = (sum * 15) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if((countOfPeople > 100)&&(countOfPeople <= 120))
            {
                if (package == "Normal")
                {
                    sum = (7500 + 500);
                    discount = (sum * 5) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                if (package == "Gold")
                {
                    sum = (7500 + 750);
                    discount = (sum * 10) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                if (package == "Platinum")
                {
                    sum = (7500 + 1000);
                    discount = (sum * 15) / 100;
                    pricePerPerson = (sum - discount) / countOfPeople;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if(countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
