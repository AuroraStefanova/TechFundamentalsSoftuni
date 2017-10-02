using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.CharRotation
{
    class CharRotation
    {
        static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
                

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            char sum = ' ';

            for (int i = 0; i < text.Length; i++)
            {

                if (numbers[i] % 2 == 0)// - 
                {
                    sum = (char)(text[i] - numbers[i]);
                    Console.Write(sum);
                }

                else if( numbers[i] % 2 != 0)//+ 
                {
                    sum = (char)(numbers[i]+ text[i]);
                    Console.Write(sum);
                }
            }
            Console.WriteLine();
        }
    }
}
