using System;
namespace _04.FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            if(num % 1 == 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(Math.Round(num));
            }
        }
    }
}
