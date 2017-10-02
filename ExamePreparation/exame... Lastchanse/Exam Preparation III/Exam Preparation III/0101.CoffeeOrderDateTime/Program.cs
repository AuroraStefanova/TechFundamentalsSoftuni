using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _0101.CoffeeOrderDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var data = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsules = long.Parse(Console.ReadLine());
                int res = DateTime.DaysInMonth(data.Year, data.Month);

                var multy = res * capsules * price;
                total += multy;
                Console.WriteLine("The price for the coffee is: ${0:f2}", multy);
            }
            Console.WriteLine("Total: ${0:f2}", total);
        }
    }
}
