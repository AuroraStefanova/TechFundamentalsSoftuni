using System;
using System.Linq;

namespace _01.SumArraysElement
{
    class SumArraysElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                num[i] = currentNumber;

            }
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                var currentNumber = num[i];
                sum += currentNumber;

            }
            Console.WriteLine(sum);
        }
    }
}
