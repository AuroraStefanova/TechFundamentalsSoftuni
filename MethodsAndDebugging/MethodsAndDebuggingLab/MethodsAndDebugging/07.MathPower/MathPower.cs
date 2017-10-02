using System;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());


            Console.WriteLine(PowerMath(first,second));
        }

        static double PowerMath(double first, double second)
        {
            double sum = first;

            for (double i = 1; i < second; i++)
            {
                sum *= first;
            }

            
            return sum;
        }
    }
}
