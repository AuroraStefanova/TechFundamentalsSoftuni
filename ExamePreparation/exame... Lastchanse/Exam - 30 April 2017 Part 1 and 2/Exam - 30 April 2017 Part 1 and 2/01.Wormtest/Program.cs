using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            long wormLenght = long.Parse(Console.ReadLine());
            double widthWorm = double.Parse(Console.ReadLine());
            double lenghtInCentimiters = wormLenght * 100;
            double divider = lenghtInCentimiters % widthWorm;
            double sum = 0;
            if(divider <= 0)
            {
                sum = lenghtInCentimiters * widthWorm;
                Console.WriteLine($"{sum:F2}");
            }
            else if(divider > 0)
            {
                sum = (lenghtInCentimiters / widthWorm) * 100;
                Console.WriteLine($"{sum:F2}%");
            }
            else if(widthWorm == 0)
            {
                sum = lenghtInCentimiters * widthWorm;
                Console.WriteLine($"{sum:F2}");
            }
        }
    }
}
