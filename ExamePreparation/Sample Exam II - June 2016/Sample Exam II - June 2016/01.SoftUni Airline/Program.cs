using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFlights = int.Parse(Console.ReadLine());
            var result = new List<decimal>();

            for (int i = 0; i < numOfFlights; i++)
            {
                decimal AdultPassengerCount = decimal.Parse(Console.ReadLine());
                decimal AdultTicketsPrice = decimal.Parse(Console.ReadLine());
                decimal YouthPassengerCount = decimal.Parse(Console.ReadLine());
                decimal YouthTicketsPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHower = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal Income = (AdultPassengerCount * AdultTicketsPrice) + (YouthPassengerCount * YouthTicketsPrice);
                decimal expenses = (flightDuration * fuelConsumptionPerHour * fuelPricePerHower);
                decimal sum = Income - expenses;
                result.Add(sum);

                if(Income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {sum:F3}$.");
                }
                else if(Income< expenses)
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {sum:F3}$.");
                }
            }

            Console.WriteLine($"Overall profit -> {result.Sum():F3}$.");
            Console.WriteLine($"Average profit -> {result.Average():F3}$.");
        }
    }
}
