using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniBeerPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> beerPong = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "stop the game")
            {
                string[] tokken = inputLine.Split('|');
                string plear = tokken[0];
                string team = tokken[1];
                int points = int.Parse(tokken[2]);

                if (!beerPong.ContainsKey(team))
                {
                    beerPong.Add(team, new Dictionary<string, int>());
                }

                if (beerPong[team].Count < 3)
                {
                    beerPong[team].Add(plear, points);
                }
                

                inputLine = Console.ReadLine();
            }
            var result = beerPong.Where(x => x.Value.Count == 3)
                .OrderByDescending(n => n.Value.Sum(pl => pl.Value));

            int count = 1;

            foreach (var teamPosition in result)
            {
                string nameOfTeam = teamPosition.Key;
                Dictionary<string, int> winners = teamPosition.Value;

                var orederPlayer = winners
                    .OrderByDescending(pleyer => pleyer.Value);

                Console.WriteLine($"{count}. {nameOfTeam}; Players:");
                foreach (var kvp in orederPlayer)
                {
                    Console.WriteLine($"###{kvp.Key}: {kvp.Value}");
                }
                count++;
            }
        }
    }
}
