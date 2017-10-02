using System;
using System.Linq;


namespace _05.IntegerToBase
{
    class IntegerToBase
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            IntToBase(number, toBase);
        }

        static string IntToBase( int numbers, int toBase)
        {
            string result = "";

            while(numbers != 0)
            {
                int remainder = numbers % toBase;
                result = remainder + result;
                numbers /= toBase;

            }
            Console.WriteLine(result);
            return result;
        }
    }
}
