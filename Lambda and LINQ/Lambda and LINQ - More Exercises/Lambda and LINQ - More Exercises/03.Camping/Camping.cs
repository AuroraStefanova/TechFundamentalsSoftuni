using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Camping
{
    class Camping
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> Camping = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();
                

            while (inputLine != "end")
            {
                string[] token = inputLine.Split(' ').ToArray();
                string namePerson = token[0];
                string camperMode = token[1];
                int timeToStay = int.Parse(token[2]);

                if (!Camping.ContainsKey(namePerson))
                {
                    Camping.Add(namePerson, new Dictionary<string, int>());
                }

                if (!Camping[namePerson].ContainsKey(camperMode))
                {
                    Camping[namePerson][camperMode] = 0;
                }

                Camping[namePerson][camperMode] += timeToStay;

                inputLine = Console.ReadLine();
            }
            int count = 1;
            
            foreach (var item in Camping.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key.Length))
            {
                int numCammpers = 0;
                var name = item.Key;
                var campers = item.Value;

                foreach (var kvpNum in item.Value)
                {

                    numCammpers ++;
                }


                Console.WriteLine($"{name}: {numCammpers}");
                int nights = 0;
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"***{kvp.Key}");
                    nights += kvp.Value;
                    numCammpers++;
                }
                Console.WriteLine($"Total stay: {nights} nights");
            }
        }
    }
}
