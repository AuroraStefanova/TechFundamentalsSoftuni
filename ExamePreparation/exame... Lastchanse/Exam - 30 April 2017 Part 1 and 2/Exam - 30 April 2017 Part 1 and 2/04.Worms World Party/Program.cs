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
            var result = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();

            while (input != "quit")
            {
                var token = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
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
                input = Console.ReadLine();
            }
            int num = 1;
            foreach (var team in result.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))//total score
            {
                string teamNAme = team.Key;
                long count = 0;
                foreach (var counting in team.Value)
                {
                    count += counting.Value;
                }
                
                Console.WriteLine($"{num}. Team: {team.Key} - {count}");
                num++;
                foreach (var kvp in team.Value.OrderByDescending(x=>x.Value))
                {
                    
                    Console.WriteLine($"###{kvp.Key} : {kvp.Value}");
                    
                }
            }
        }
    }
}
