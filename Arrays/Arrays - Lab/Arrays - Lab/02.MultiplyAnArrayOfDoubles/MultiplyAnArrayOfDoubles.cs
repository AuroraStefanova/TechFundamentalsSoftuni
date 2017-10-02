using System;
using System.Linq;
namespace _02.MultiplyAnArrayOfDoubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToList();

            double pNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < array.Count; i++)
            {
                array[i] *= pNum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
