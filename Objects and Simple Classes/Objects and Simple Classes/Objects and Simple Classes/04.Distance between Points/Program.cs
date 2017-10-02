using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main()
        {
            var firstPointPart = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            var firstPint = new point
            {
                X = firstPointPart[0],
                Y = firstPointPart[1]

            };
            var secondPointParts = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            var secondPoint = new point
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]

            };

            var result = Distance(firstPint, secondPoint);
            Console.WriteLine($"{result:F3}");

            //sqrt((x1 - x2)^2 + (Y1 - Y2)^2)
        }
        public static double Distance(point first, point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }

}
