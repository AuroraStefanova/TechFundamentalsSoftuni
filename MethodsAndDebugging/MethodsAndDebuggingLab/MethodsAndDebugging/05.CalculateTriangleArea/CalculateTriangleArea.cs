using System;

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double aSide = double.Parse(Console.ReadLine());
            double bSide = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(aSide, bSide));
        }

        static double TriangleArea(double pesho, double gosho)
        {
            double sum = (pesho * gosho) / 2;
            //Console.WriteLine(sum);
            
            return sum;
            
        }
    }
}
