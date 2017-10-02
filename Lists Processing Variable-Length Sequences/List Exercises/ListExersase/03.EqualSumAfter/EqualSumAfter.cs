using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.EqualSumAfter
{
    class EqualSumAfter
    {
        static void Main()
        {
            var firstNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //var
            for (int i = 0; i < firstNum.Count; i++)
            {
                for (int j = 0; j < secondNum.Count; j++)
                {
                    if (firstNum[i] == secondNum[j])
                    {
                        secondNum.RemoveAt(j);
                        j--;
                    }

                }
            }
            long sum2 = secondNum.Sum();
            long sum1 = 0L;

            foreach (int number in firstNum)
            {
                sum1 += number;
            }
            if(sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum2}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
