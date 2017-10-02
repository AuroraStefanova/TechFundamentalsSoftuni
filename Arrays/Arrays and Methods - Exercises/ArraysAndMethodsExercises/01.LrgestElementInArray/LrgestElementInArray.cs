using System;
using System.Linq;

namespace _01.LrgestElementInArray
{
    class LrgestElementInArray
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var number = new int[num];

            for (int i = 0; i < number.Length; i++)
            {
                var current = int.Parse(Console.ReadLine());
                number[i] = current;
            }
            var largeNum = int.MinValue;

            for (int i = 0; i < number.Length; i++)
            {
                var currentNumber = number[i];

                if (currentNumber > largeNum)
                {
                    largeNum = currentNumber;
                }
            }
            Console.WriteLine(largeNum);
        }
    }
}
