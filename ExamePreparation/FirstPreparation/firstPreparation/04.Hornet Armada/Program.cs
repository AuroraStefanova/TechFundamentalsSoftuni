using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var ActivityLegion = new Dictionary<string, int>();
            var legionSolgerTypeAndCount = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine().Split(new string[] { " ", "=", "-", ">", ":" }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(inputLine[0]);
                string legionName = inputLine[1];
                string solderType = inputLine[2];
                long countSolder = long.Parse(inputLine[3]);

                if (!legionSolgerTypeAndCount.ContainsKey(legionName))
                {
                    legionSolgerTypeAndCount[legionName] = new Dictionary<string, long>();
                    ActivityLegion[legionName] = lastActivity;
                }

                if(ActivityLegion[legionName] < lastActivity)
                {
                    ActivityLegion[legionName] = lastActivity;
                }

                if (!legionSolgerTypeAndCount[legionName].ContainsKey(solderType))
                {
                    legionSolgerTypeAndCount[legionName][solderType] = 0;

                }
                legionSolgerTypeAndCount[legionName][solderType] += countSolder;

            }

            var token = Console.ReadLine().Split('\\').ToList();

            if(token.Count == 2)
            {
                int activity = int.Parse(token[0]);
                string solderType = token[1];

                foreach (var item in legionSolgerTypeAndCount.Where(x => x.Value.ContainsKey(solderType))
                    .OrderByDescending(x => x.Value[solderType]))
                {   
                    if(ActivityLegion[item.Key] < activity)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[solderType]}");
                    }

                }
            }
            else
            {
                foreach (var kvp in ActivityLegion.OrderByDescending(c => c.Value))
                {
                    if (legionSolgerTypeAndCount[kvp.Key].ContainsKey(token[0]))
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
        }
    }
}
