using System;

namespace _06.IntervalOf_Numbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int biger = 0;
            int oldFirst = 0;
            if(firstNum > secondNum)
            {
                oldFirst = secondNum;
                 biger = firstNum;
            }
            if(firstNum < secondNum)
            {
                biger = secondNum;
                oldFirst = firstNum;
            }

            for (int i = oldFirst; i <= biger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
