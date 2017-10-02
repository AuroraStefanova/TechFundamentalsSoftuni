using System;
using System.Linq;


namespace _10.BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main()
        {
            var coordinates = Console.ReadLine()// 35  - 2
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var instruction = Console.ReadLine()
                .Split(' ');

            int sumX = 0;
            int sumY = 0;

            for (int i = 0; i < instruction.Length; i+=2)
            {

                //  Up increases y by the next number. +
                //•	Down decreases y by the next number. -
                //•	Left decreases x by the next number. - 
                //•	Right increases x by the next number. + 

                

                if (instruction[i] == "up")
                {
                    sumY += int.Parse(instruction[i + 1]);
                }
                if(instruction[i] == "down")
                {
                    sumY -= int.Parse(instruction[i + 1]);
                }
                if(instruction[i] == "right")
                {
                    sumX += int.Parse(instruction[i + 1]);
                }
                if(instruction[i] == "left")
                {
                    sumX -= int.Parse(instruction[i + 1]);
                }


            }
            if(sumX == coordinates[0] && sumY == coordinates[1])
            {
                Console.WriteLine($"firing at [{sumX}, {sumY}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{sumX}, {sumY}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
