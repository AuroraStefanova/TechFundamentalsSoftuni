using System;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            switch (month)
            {
                case "May":
                case "October": priceStudio = 50; priceDouble = 65; priceSuite = 75; break;
                case "June":
                case "September": priceStudio = 60; priceDouble = 72; priceSuite = 82; break;
                case "July":
                case "August":
                case "December": priceStudio = 68; priceDouble = 77; priceSuite = 89; break;
            }
            if((month == "May"||month == "October")&&nights > 7)
            {
                priceStudio *= 0.95;

            }
            else if((month == "June" || month == "September")&& nights > 14)
            {
                priceDouble *= 0.9;
            }
            else if((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                priceSuite *= 0.85;

            }
            double finalPriceStudio = priceStudio * nights;
            double finalPriceDouble = priceDouble * nights;
            double finalPriceSuite = priceSuite * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                finalPriceStudio -= priceStudio;
            }

            Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {finalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {finalPriceSuite:f2} lv.");
        }
    }
}
