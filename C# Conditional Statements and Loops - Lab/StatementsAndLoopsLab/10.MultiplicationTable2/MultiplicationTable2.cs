using System;

namespace _10.MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sum = 0;

            if(secondNum > 10)
            {
                sum = firstNum * secondNum;
                Console.WriteLine($"{firstNum} X {secondNum} = {sum}");
            }
            else
            {
                for (int i = secondNum; i <= 10; i++)
                {
                    sum = firstNum * i;
                    Console.WriteLine($"{firstNum} X {i} = {sum}");
                }
            }


        }
    }
}
