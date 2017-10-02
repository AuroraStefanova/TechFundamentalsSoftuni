using System;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if(num % 1 == 0)
                {
                    Console.WriteLine("It is a number.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
