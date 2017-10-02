using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDist = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double milesInHeavyWind = double.Parse(Console.ReadLine());

            double withoutHavy = tripDist - milesInHeavyWind;
            double inHeavy = withoutHavy * 25;
            double heavy = milesInHeavyWind *( 25 * 1.5);
            double neededFuel = inHeavy + heavy;
            double tolerance = (neededFuel * 5) / 100;
            double total = tolerance + neededFuel;

            Console.WriteLine($"Fuel needed: {total:F2}L");

            if(total <= tankCapacity)
            {
                double sum = tankCapacity - total;
                Console.WriteLine($"Enough with {sum:f2}L to spare!");
            }
            else
            {
                double sum = total - tankCapacity;
                Console.WriteLine($"We need {sum:F2}L more fuel.");
            }
        }
    }
}
