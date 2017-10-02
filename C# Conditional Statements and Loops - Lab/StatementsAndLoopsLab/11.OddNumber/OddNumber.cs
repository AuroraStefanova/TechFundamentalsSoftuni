using System;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            while(num % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The number is: {0}", Math.Abs(num));
        }
    }
}
