using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int perMile = 25;//l
            double tripDistace = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double milesInHeavyWind = double.Parse(Console.ReadLine());
            //5% more fuel 
            double notHeavyWind = tripDistace - milesInHeavyWind;
            double consumNotHeavyWind = notHeavyWind * perMile;
            double consumationHeavy = (milesInHeavyWind * perMile) * 1.5;
            double consumation = consumationHeavy + consumNotHeavyWind;
            double tolerance = (consumation * 5) / 100;
            double total = tolerance + consumation;
            Console.WriteLine($"Fuel needed: {total:F2}L");

            if(total <= tankCapacity)
            {
                var result = tankCapacity - total;
                Console.WriteLine($"Enough with {result:F2}L to spare!");
            }
            else
            {
                var result = total - tankCapacity;
                Console.WriteLine($"We need {result:F2}L more fuel.");
            }
        }
    }
}
