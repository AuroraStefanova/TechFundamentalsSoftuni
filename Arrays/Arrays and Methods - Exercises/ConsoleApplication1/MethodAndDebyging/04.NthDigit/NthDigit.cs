using System;
using System.Linq;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            long longestNumber = long.Parse(Console.ReadLine());
            int indexNumber = int.Parse(Console.ReadLine());

            FindingNthNumber(longestNumber, indexNumber);

        }
        static int FindingNthNumber(long first, int second)
        {
            long digits = 0;
            int count = 0;
            while(first > 0)
            {
                digits = first % 10;
                count++;

                if(count == second)
                {
                    break;
                }
                first /= 10;
            }

            Console.WriteLine(digits);
            return count;
        }
    }
}
