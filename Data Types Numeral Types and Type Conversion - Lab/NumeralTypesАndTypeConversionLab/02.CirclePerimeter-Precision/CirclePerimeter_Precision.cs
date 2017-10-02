using System;


namespace _02.CirclePerimeter_Precision
{
    class CirclePerimeter_Precision
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}
