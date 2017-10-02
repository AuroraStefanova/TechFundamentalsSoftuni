using System;

namespace _05.DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main()
        {
            double earthToNearest = 4.22;
            double GalaxyTheMilkyWay = 26000;
            double diamererMilkiWay = 100000;
            double observableUniverse = 46500000000;

            double lightYear = 9450000000000;
            double nearest = earthToNearest * lightYear;
            Console.WriteLine("{0:e2}", nearest);
            double centerToMilkiWay = lightYear * GalaxyTheMilkyWay;
            Console.WriteLine("{0:e2}", centerToMilkiWay);
            double milkiWayDiameters = diamererMilkiWay * lightYear;
            Console.WriteLine($"{milkiWayDiameters:e2}");
            double distanceObservableUniverse = observableUniverse * lightYear;
            Console.WriteLine($"{distanceObservableUniverse:e2}");


        }
    }
}
