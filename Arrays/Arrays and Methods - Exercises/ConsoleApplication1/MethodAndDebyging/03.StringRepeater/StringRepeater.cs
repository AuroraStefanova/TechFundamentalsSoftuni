using System;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            RepeatString(word, num);
        }
        static string RepeatString(string word, int num)
        {
            string repeat = string.Empty;

            for (int i = 0; i < num; i++)
            {
                repeat += word;
            }
            Console.WriteLine(repeat);
            return repeat;
        }
    }
}
