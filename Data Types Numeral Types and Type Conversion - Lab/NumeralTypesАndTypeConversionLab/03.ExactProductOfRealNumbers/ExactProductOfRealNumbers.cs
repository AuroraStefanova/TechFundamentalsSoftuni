using System;


namespace _03.ExactProductOfRealNumbers
{
    class ExactProductOfRealNumbers
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal product = 1;
            for (decimal i = 0; i < n; i++)
            {
                decimal some = decimal.Parse(Console.ReadLine());
                product *= some;
            }
                
            Console.WriteLine(product);

        }
    }
}
