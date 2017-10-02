using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            var words = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }
            var oddList = new List<string>();
            foreach (var kvp in result)
            {
                int value = kvp.Value;
                if (kvp.Value % 2 != 0)
                {
                    oddList.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddList));
        }
    }
}
