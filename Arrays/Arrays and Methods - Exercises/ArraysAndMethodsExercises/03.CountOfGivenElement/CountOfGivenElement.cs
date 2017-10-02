using System;
using System.Linq;


namespace _03.CountOfGivenElement
{
    class CountOfGivenElement
    {
        static void Main()
        {
            var num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int givenElement = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {

                if(givenElement == num[i])
                {
                    count++;

                }
            }
            Console.WriteLine(count);
        }
    }
}
