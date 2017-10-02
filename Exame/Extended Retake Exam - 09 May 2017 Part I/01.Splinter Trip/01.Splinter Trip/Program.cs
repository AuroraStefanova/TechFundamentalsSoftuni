using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main()
        {
            double tripDist = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double spentInHeavyWinds = double.Parse(Console.ReadLine());

            double NotHeveayWind = (tripDist -spentInHeavyWinds)*25;//
            double inHeavyWinds = (spentInHeavyWinds * 1.5)*25;// 
            double total = (NotHeveayWind + inHeavyWinds);//
            double allfuel = ((total * 5) / 100) + total;// tolersnce

            //Console.WriteLine($"Fuel needed: {allfuel:F2}L");
            //
            //if( allfuel <= tankCapacity)
            //{
            //    double sum = tankCapacity - allfuel;
            //    Console.WriteLine($"Enough with {sum:F2}L to spare!");
            //}
            //else//fuel > tank
            //{
            //    double sum = allfuel - tankCapacity;
            //    Console.WriteLine($"We need {sum:F2}L more fuel.");
            //}
            //
        }
    }
}
