using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            long maratonDays = long.Parse(Console.ReadLine());
            long maxRunners = long.Parse(Console.ReadLine());
            long avarageLapsPerRunner = long.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());//in miters
            long capacityTrack = long.Parse(Console.ReadLine());//max runners
            decimal monyPerCilometer = decimal.Parse(Console.ReadLine());

            long totalMiters = 0;
            decimal kilomiters = 0;
            decimal monyRiced = 0;
            long totalNumOfRunners = 0;
            long capacity = capacityTrack * maratonDays;
            if (capacity >= maxRunners)
            {
                totalNumOfRunners = maxRunners;
            }
            else if(capacity < maxRunners )
            {
                totalNumOfRunners = capacityTrack;
            }
            totalMiters = (totalNumOfRunners * avarageLapsPerRunner) * trackLenght;
            kilomiters = totalMiters / 1000;
            monyRiced = kilomiters * monyPerCilometer;

            Console.WriteLine($"Money raised: {monyRiced:F2}");
        }
    }
}
