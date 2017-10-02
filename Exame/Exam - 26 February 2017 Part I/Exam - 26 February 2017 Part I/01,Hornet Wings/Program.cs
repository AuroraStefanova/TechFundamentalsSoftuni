using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
             int WingFlaps = int.Parse(Console.ReadLine());//N
             double distanceInMeters = double.Parse(Console.ReadLine());//M 1000 per miters 
             int endurance = int.Parse(Console.ReadLine());//P  wing flaps he can make, before he stops to take a break He rest 5 second 
             int perSecond = 100; // wings flap per second 

            int rests = WingFlaps / endurance;
            long seconds = rests * 5;
            double distance = (WingFlaps / 1000) * distanceInMeters;
            seconds += (WingFlaps / 100);

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
