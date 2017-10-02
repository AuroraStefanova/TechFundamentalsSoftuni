using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersNumber = int.Parse(Console.ReadLine());
            decimal price = 0;

            for (int i = 0; i < ordersNumber; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string dateString = Console.ReadLine();
                DateTime orderDate = DateTime.ParseExact(dateString, "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsulesCaunt = decimal.Parse(Console.ReadLine());

                var year = orderDate.Year;
                var month = orderDate.Month;
                int days = DateTime.DaysInMonth(year, month);

                decimal currentPrice = (days * capsulesCaunt) * pricePerCapsule;
                price += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            
            }
            Console.WriteLine($"Total: ${price:F2}");
        }
    }
}
