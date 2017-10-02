using System;

namespace MethodsAndDebugging
{
    class Program
    {
        static void Main()
        {
            var num = 4;
            var numSquard = GetSquare(num);
            Console.WriteLine(numSquard);

        }

        static double GetSquare(double number)
        {
            var result = number * number;
            return result;
        }


    }
}
