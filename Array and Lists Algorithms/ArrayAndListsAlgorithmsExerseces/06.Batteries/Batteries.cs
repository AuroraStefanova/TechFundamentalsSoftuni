using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main()
        {
            var capacities = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var usegePerHower = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            double howerStresTest = double.Parse(Console.ReadLine());

            var usegePlusHower = new List<double>();

            var result = new List<double>();

            for (int i = 0; i < usegePerHower.Count; i++)
            {
                double index = usegePerHower[i] * howerStresTest;
                usegePlusHower.Add(index);

                result.Add(capacities[i] - usegePlusHower[i]);

                if(result[i] < 0)
                {
                    var diff = (Math.Ceiling(capacities[i] / usegePerHower[i]));
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", result.Count, diff);
                    
                }

                else
                {
                    var percent = (result[i] / capacities[i]) * 100;
                    Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%", result.Count, result[i], percent);
                }
            }
        }
    }
}
