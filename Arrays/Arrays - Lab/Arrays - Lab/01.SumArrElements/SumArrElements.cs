using System;

namespace _01.SumArrElements
{
    class SumArrElements
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                sum += elements;
            }
            Console.WriteLine(sum);
        }
    }
}
