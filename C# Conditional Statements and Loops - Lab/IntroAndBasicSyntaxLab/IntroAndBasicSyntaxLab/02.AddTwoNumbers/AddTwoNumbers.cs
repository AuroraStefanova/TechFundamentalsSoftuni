﻿using System;

namespace _02.AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum;
            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }
    }
}
