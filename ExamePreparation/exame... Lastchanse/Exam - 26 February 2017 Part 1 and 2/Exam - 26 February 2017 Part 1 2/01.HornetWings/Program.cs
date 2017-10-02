using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingsFlap = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double miters = (wingsFlap / 1000) * distance;
            
            double flapsPerSecond = wingsFlap / 100;
            double result = ((wingsFlap / endurance) * 5) + flapsPerSecond;

            Console.WriteLine($"{ miters:F2} m.");
            Console.WriteLine($"{result} s.");
        }
    }
}
