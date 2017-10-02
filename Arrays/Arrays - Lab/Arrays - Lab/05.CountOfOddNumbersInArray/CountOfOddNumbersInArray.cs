using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main()
        {
            int countOdd = 0;
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    countOdd++;
                }
            }
            Console.WriteLine(countOdd);
        }
    }
}
