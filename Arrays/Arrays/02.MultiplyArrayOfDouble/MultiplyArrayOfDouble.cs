using System;
using System.Linq;
namespace _02.MultiplyArrayOfDouble
{
    class MultiplyArrayOfDouble
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var p = double.Parse(Console.ReadLine());
            //var j = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

           // while (j < numbers.Length)
           // {
           //     numbers[j] *= p;
           //
           //     j++;
           // }
            var result = string.Join(" ", numbers);
            Console.WriteLine(numbers);
        }
    }
}
