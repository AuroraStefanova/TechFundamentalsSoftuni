using System;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            double mils = double.Parse(Console.ReadLine());

            double kilometresToMiles = 1.60934;

            double sum = mils * kilometresToMiles;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
