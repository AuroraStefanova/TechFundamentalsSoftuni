using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var NameInQuest = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var SongInQuest = Console.ReadLine().Split(new string[] { ", "},
                StringSplitOptions.RemoveEmptyEntries);
            var Result = new Dictionary<string, List<string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "dawn")
            {
                var token = inputLine.Split(new string[] { ", "}, StringSplitOptions.RemoveEmptyEntries);
                string name = token[0];
                string song = token[1];
                string awards = token[2];

                if(!NameInQuest.Contains(name) || !SongInQuest.Contains(song))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (!Result.ContainsKey(name))
                {
                    Result.Add(name, new List<string>());
                }

                if (!Result[name].Contains(awards))
                {
                    Result[name].Add(awards);
                }

                inputLine = Console.ReadLine();
            }

            int count = 0;
            foreach (var kvp in Result.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, y => y.Value.OrderBy(x => x).ToList()))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    count++;
                    Console.WriteLine($"--{kvp.Value[i]}");
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
