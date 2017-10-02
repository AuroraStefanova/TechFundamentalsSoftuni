using System;
using System.Collections.Generic;
using System.Linq;
namespace _6.ForumTopics
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(new string[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, HashSet<string>> forumTopics = new Dictionary<string, HashSet<string>>();
            while (inputLine[0] != "filter")
            {
                string firstText = inputLine[0];
                string[] secondWords = inputLine[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!forumTopics.ContainsKey(firstText))
                {
                    forumTopics[firstText] = new HashSet<string>();
                }

                foreach (var wordBycomma in secondWords)
                {
                        forumTopics[firstText].Add(wordBycomma);                   
                }
                inputLine = Console.ReadLine().Split(new string[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] secondInputLine = Console.ReadLine().Split(new string[] {", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var keyContains in forumTopics)
            {
                string first = keyContains.Key;
                int contein = 0;

                for (int i = 0; i < secondInputLine.Length; i++)
                {
                    if (keyContains.Value.Contains(secondInputLine[i]))
                    {
                        contein++;
                    }
                }
                if (contein == secondInputLine.Length)
                {
                    Console.WriteLine($"{first} | #{string.Join(", #", keyContains.Value)}");
                }
            }
        }
    }
}
