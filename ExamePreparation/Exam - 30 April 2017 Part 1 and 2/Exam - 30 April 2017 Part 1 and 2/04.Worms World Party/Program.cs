using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var  result = new Dictionary<string, Dictionary<string, long>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "quit")
            {
                var token = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = token[0];
                string team = token[1];
                long score = long.Parse(token[2]);

                if (!result.ContainsKey(team))
                {
                    result[team] = new Dictionary<string, long>();
                }

                foreach (var item in result)
                {
                    if (item.Value.ContainsKey(name))
                    {
                        break;
                    }
                    else
                    {
                        if (!result[team].ContainsKey(name))
                        {
                            result[team][name] = score;
                        }
                    }
                }  

                inputLine = Console.ReadLine();
            }
            int count = 1;
            foreach (var team in result.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x=>x.Value.Values.Average()))//total score
            {
                long pointTeam = 0;
                string teamName = team.Key;


                foreach (var points in team.Value)
                {
                    pointTeam += points.Value;
                }
                

                Console.WriteLine($"{count}. Team: {teamName} - {pointTeam}");
                count++;
                foreach (var name in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{name.Key} : {name.Value}");
                }
            }
        }
    }
}
