using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main()
        {
            var someText = Console.ReadLine()
                .Split(' ')
                .Reverse()
                .ToArray();

            int count = 1;
            string something = string.Empty;



            //for (int i = someText.Length - 1; i > 0; i--)
            for (int i = 0; i < someText.Length - 1; i++)

            {
                
                if (someText[i] == someText[i + 1])
                {
                    count++;
                    //something += someText[i] + " ";

                }

                else
                {
                    count = 1;
                }

                if (count == 3)
                {
                    Console.WriteLine("{0} {0} {0}", someText[i]);
                    //Console.WriteLine(something);
                    break;
                }
            }
        }
    }
}
