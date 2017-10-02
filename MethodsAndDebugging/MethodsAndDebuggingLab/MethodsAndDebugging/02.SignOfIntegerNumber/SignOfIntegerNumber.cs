using System;

namespace _02.SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            PrintNum(n);
        }

        static void PrintNum(int n)
        {
            if(n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if( n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
