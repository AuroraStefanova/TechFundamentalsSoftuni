using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "quit")
            {
                string[] token = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = token[0];
                string team = token[1];
                int points = int.Parse(token[2]);
                if(data.Any())

                if (!data.ContainsKey(team))
                {
                    data.Add(team, new Dictionary<string, int>());

                }
                
                if (!data[team].ContainsKey(name))
                {
                    data[team][name] = 0;
                }
                data[team][name] = points;


                inputLine = Console.ReadLine();
            }
            int count = 1;
            var point = 0;
            var totalScore = 0;
            foreach (var item in data)
            {
                string team = item.Key;

                var totalValue = 0;
                foreach (var fuck in item.Value)
                {
                    totalValue += fuck.Value;
                }
                foreach (var score in data)
                {
                    foreach (var total in score.Value)
                    {
                        totalScore += total.Value;
                    }
                }
                Console.WriteLine(totalScore);

                Console.WriteLine($"{count}. Team: {team} - {totalValue}");

                foreach (var kvp in item.Value.OrderByDescending(x => x.Value).ThenBy(tim => tim.Value))
                {
                    point += kvp.Value;
                    Console.WriteLine($"###{kvp.Key} : {kvp.Value}");
                }
                count++;
            }

        }
    }
}
