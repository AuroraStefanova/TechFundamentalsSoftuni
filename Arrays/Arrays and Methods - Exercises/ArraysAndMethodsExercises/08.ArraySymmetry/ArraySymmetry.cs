using System;
using System.Linq;
namespace _08.ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main()
        {
            var textOfString = Console.ReadLine()
                .Split(' ');

            for (int i = 0; i < textOfString.Length/2; i++)
            {
                if(textOfString[i] == textOfString[textOfString.Length - 1 -i])
                {
                    Console.WriteLine("Yes");
                    return;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }

            }
        }
    }
}
