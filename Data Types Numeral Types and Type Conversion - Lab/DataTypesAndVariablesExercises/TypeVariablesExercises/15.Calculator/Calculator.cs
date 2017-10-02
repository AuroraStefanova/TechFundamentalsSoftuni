using System;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            switch (operators)
            {
                case "+":
                    Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum} ");
                    break;
                case "*":
                    Console.WriteLine($"{firstNum} * {secondNum} = {firstNum *secondNum}");
                    break;
                case "/":
                    Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                    break;
            }
        }
    }
}
