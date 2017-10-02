using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            long P = long.Parse(Console.ReadLine());

            var distanceInMiters = (N / 1000) * M;

            var hornetFlaps = N / 100;
            var rest = (N / P) * 5;
            var result = hornetFlaps + rest;

            Console.WriteLine($"{distanceInMiters:F2} m.");
            Console.WriteLine($"{result} s.");
        }
    }
}
