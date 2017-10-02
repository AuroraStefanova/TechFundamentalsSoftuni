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
            long wormLenght = long.Parse(Console.ReadLine());// in meters 
            double width = double.Parse(Console.ReadLine());// in centimeters 

            double convertedLenght = wormLenght * 100;

            double divider = convertedLenght % width;

            if(width == 0)
            {
                double productSum = convertedLenght * width;
                Console.WriteLine($"{productSum:F2}");
            }
            else if(divider != 0 )
            {
                double percent =( convertedLenght / width);
                double sum = percent * 100;
                Console.WriteLine($"{sum:F2}%");
            }
            else if(divider <= 0)
            {
                var sum = convertedLenght * width;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
