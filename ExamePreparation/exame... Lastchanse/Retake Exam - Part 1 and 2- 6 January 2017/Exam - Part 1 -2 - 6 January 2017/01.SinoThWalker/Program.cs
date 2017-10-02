using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoThWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] time = Console.ReadLine().Split(':').Select(decimal.Parse)
                .ToArray();
            decimal stepsFromHome = decimal.Parse(Console.ReadLine());
            decimal stepsPerSecond = decimal.Parse(Console.ReadLine());
            decimal seconds = 60;
            decimal minutes = seconds * 60;

            decimal howersTake = time[0];
            decimal minutesTake = time[1];
            decimal secondsTake = time[2];

            decimal timeToHome = stepsFromHome * stepsPerSecond;
            decimal secondsToHome = (howersTake * minutes) + (seconds * minutesTake) + (secondsTake) + (timeToHome);

            decimal hower = secondsToHome / (60 * 60);//60 sec * 60 min
            decimal min = (secondsToHome % (60 * 60)) / 60;// min = (secondsToHome % 3600) / 60;
            decimal sec = (secondsToHome % 60);

            Console.WriteLine($"Time Arrival: {(long)hower % 24:D2}:{(long)min:D2}:{(long)sec:D2}");
        }
    }
}
