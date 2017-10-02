using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveElementAtOddPosition
{
    class RemoveElementAtOddPosition
    {
        static void Main()
        {
            var someText = Console.ReadLine()
                .Split(' ')
                .ToList();

            var textNew = new List<string>();

            for (int i = 0; i < someText.Count; i++)
            {
                if( i % 2 != 0)
                {
                    textNew.Add(someText[i]);
                }
            }
            Console.WriteLine(String.Join("", textNew));
        }
    }
}
