using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.DebuggingExerciseTrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimeter = Console.ReadLine();
            int numberString = int.Parse(Console.ReadLine());
            var result = string.Empty;

            for (int i = 0; i < numberString; i++)
            {
                if(i < numberString - 1)
                {
                    result += Console.ReadLine() + delimeter;
                    continue;
                }
                result += Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
