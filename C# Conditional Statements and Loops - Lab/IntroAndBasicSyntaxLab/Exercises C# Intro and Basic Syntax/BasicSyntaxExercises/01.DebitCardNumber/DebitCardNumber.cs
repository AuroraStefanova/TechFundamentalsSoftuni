using System;

namespace _01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:0000} {secondNum:0000} {thirdNum:0000} {forthNum:0000}");

        }
    }
}
