using System;
using System.Linq;

namespace _04.RotateArrayToString
{
    class RotateArrayToString
    {
        static void Main()
        {
            string[] stringOfElements = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var newString = new string[stringOfElements.Length];
            newString[0] = stringOfElements[stringOfElements.Length - 1];

            for (int i = 0; i < stringOfElements.Length - 1; i++)
            {
                newString[i + 1] = stringOfElements[i];
            }

            var result = string.Join(" ", newString);
            Console.WriteLine( result);
        }
    }
}
