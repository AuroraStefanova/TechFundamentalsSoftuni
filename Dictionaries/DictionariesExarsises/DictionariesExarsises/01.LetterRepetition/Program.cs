using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LetterRepetition
{
    class Program
    {
        static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();

            Dictionary<char, int> countLetters = new Dictionary<char, int>();

            foreach (var letters in text)
            {
                if (!countLetters.ContainsKey(letters))
                {
                    countLetters[letters] = 0;
                }
                countLetters[letters]++;
            }
            foreach (var kvp in countLetters)
            {
                char key = kvp.Key;
                int value = kvp.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
