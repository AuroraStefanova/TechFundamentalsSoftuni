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
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

            var names = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var songInput = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] token = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string participant = token[0];
                string song = token[1];
                string award = token[2];

                //todo if not contains

                if (!songInput.Contains(song) || !names.Contains(participant))
                {
                    input = Console.ReadLine();

                    continue;
                }
                if(!results.ContainsKey(participant))
                {
                    results.Add(participant, new List<string>());
                }
                if (!results[participant].Contains(award))
                {
                    results[participant].Add(award);
                }
                //if (!results[participant].Contains(award))
                //{
                //    results[participant].Add(award);
                //}
                input = Console.ReadLine();

            }
            int count = 0;
            foreach (var result in results.OrderByDescending(x=>x.Value.Count).ToDictionary(y=>y.Key,y=>y.Value.OrderBy(x=>x).ToList()))
            {
                Console.WriteLine($"{result.Key}: {result.Value.Count} awards");

                for (int i = 0; i < result.Value.Count; i++)
                {
                    count++;
                    Console.WriteLine($"--{result.Value[i]}");
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
