using System;

namespace _08.TravelingLightSpeed
{
    class TravelingLightSpeed
    {
        static void Main()
        {
            decimal lightYearsNeed = decimal.Parse(Console.ReadLine());
            decimal kilometres = 9450000000000 * lightYearsNeed;
            decimal speedOfLight = 300000;// kilometres per second

            decimal second = kilometres / speedOfLight;
            
            decimal min = second / 60;
            second %= 60;
            decimal hours = min / 60;
            min %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal weeks = days / 7;
            days %= 7;

            Console.WriteLine("{0} weeks", (int)weeks);
            Console.WriteLine("{0} days", (int)days);
            Console.WriteLine("{0} hours", (int)hours);
            Console.WriteLine("{0} minutes", (int)min);
            Console.WriteLine("{0} seconds", (int)second);
        }
    }
}
