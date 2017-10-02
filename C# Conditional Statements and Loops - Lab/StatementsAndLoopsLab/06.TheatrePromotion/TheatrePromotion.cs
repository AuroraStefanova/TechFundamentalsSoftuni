using System;

namespace _06.TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine();
            int years = int.Parse(Console.ReadLine());
            int ticket = 0;


            if(years >= 0 && years <= 18)
            {
                if(typeOfDay == "Weekday")
                {
                    ticket = 12;
                }
                else if(typeOfDay == "Weekend")
                {
                    ticket = 15;
                }
                else if(typeOfDay == "Holiday")
                {
                    ticket = 5;
                }
            }
            else if(years > 18 && years <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    ticket = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticket = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticket = 12;
                }
            }
            else if(years > 64 && years <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    ticket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    ticket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    ticket = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"{ticket}$");
        }
    }
}
