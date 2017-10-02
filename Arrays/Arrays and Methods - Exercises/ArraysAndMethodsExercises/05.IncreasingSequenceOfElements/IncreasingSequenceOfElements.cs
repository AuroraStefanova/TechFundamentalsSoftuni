using System;
using System.Linq;


namespace _05.IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main()
        {
            var num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < num.Length - 1; i++)
            {
                if(num[i] > num[i + 1])
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
