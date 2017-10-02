using System;
using System.Linq;
namespace _07.CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ');

            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                char first = word[0];

                if (word.Length == 1 && Char.IsUpper(first) )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
