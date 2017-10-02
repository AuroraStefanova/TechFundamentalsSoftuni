using System;
using System.Linq;


namespace _04.OccurrencesOfLargerNumbersInArray
{
    class OccurrencesOfLargerNumbersInArray
    {
        static void Main()
        {
            var num = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double largestNumber = double.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if(largestNumber < num[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
