using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KeyKeyValueValue
{
    class KeyKeyValueValue
    {
        static void Main()
        {
            string keyRecive = Console.ReadLine();
            string valueRecive = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> ContainsDict = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                string comand = input[0];

                if (!ContainsDict.ContainsKey(comand))
                {
                    ContainsDict[comand] = new List<string>();
                }

                string[] someText = input[1].Split(';');

                foreach (var words in someText)
                {
                        ContainsDict[comand].Add(words);
                }
            }

            foreach (var existElements in ContainsDict)
            {
                string first = existElements.Key;
                if (first.Contains(keyRecive))
                {
                    Console.WriteLine($"{first}:");
                }
                else
                {
                    continue;
                }
                foreach (var kvp in existElements.Value)
                {
                    if (kvp.Contains(valueRecive))
                    {
                        Console.WriteLine($"-{kvp}");
                    }
                }
            }
        }
    }
}
