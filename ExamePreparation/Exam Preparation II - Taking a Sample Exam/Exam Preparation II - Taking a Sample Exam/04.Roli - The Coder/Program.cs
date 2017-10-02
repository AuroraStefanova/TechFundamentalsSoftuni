using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var result = new Dictionary<int, Dictionary<string, SortedSet<string>>>();

            while (inputLine != "Time for Code")
            {
                var token = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                int id = int.Parse(token[0]);
                string eventName = token[1];
                if (eventName.Contains("#"))
                {
                    if (!result.ContainsKey(id))
                    {
                        result[id] = new Dictionary<string, SortedSet<string>>();
                    }
                    if (result.ContainsKey(id))
                    {
                        continue;
                    }

                    if (!result[id].ContainsKey(eventName))
                    {

                        result[id][eventName] = new SortedSet<string>();
                    }
                    string[] participiant = token.Skip(2).ToArray();
                    foreach (var person in participiant)
                    {
                        if (person.Contains("@"))
                        {
                            result[id][eventName].Add(person);
                        }
                    }
                }
                else
                {
                    continue;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var item in result.OrderByDescending(x => x.Value.Values.Count))
            {
                foreach (var kvp in item.Value)
                {
                    int count = 0;
                    foreach (var counting in kvp.Value)
                    {
                        count++;
                    }
                    string newName = "";

                    for (int i = 1; i < kvp.Key.Length; i++)
                    {
                        newName += kvp.Key[i];
                    }
                    Console.WriteLine($"{newName} - {count}");
                    Console.WriteLine(string.Join("\n\r", kvp.Value));
                }
            }
        }
    }
}

