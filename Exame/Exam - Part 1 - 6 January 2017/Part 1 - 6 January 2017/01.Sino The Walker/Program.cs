using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main()
        {
            decimal[] time = Console.ReadLine().Split(':').Select(decimal.Parse)
                .ToArray();//howers

            decimal steps = decimal.Parse(Console.ReadLine());
            decimal stepPerSecond = decimal.Parse(Console.ReadLine());

            decimal seconds = 60;
            decimal minutes = seconds * 60;

            decimal howersTaken = time[0];
            decimal minTaken = time[1];
            decimal secondTaken = time[2];
            decimal alltime = steps * stepPerSecond;
            decimal secondsToHome = (howersTaken * minutes) + (seconds * minTaken) + (secondTaken) + (alltime);



            decimal how = secondsToHome / (60 * 60);
            decimal min = (secondsToHome % 3600) / 60;
            decimal sec = (secondsToHome % 60);

            
            Console.WriteLine($"Time Arrival: {(long)how % 24:D2}:{(long)min:D2}:{(long)sec:D2}");


        }
    }
}
