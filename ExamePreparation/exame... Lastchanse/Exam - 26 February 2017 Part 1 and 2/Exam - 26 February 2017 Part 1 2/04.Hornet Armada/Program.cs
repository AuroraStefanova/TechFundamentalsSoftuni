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
            var activityAndLegion = new Dictionary<string, int>();
            var legionSoldierTypeAndCounter = new Dictionary<string, Dictionary<string, long>>();
             

            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new string[] { " ", "-", ">", ":", "=" }, StringSplitOptions.RemoveEmptyEntries);
                string legionName = inputLine[1];
                int lastActivity = int.Parse(inputLine[0]);
                string solderType = inputLine[2];
                long CountSolder = long.Parse(inputLine[3]);
                if (!legionSoldierTypeAndCounter.ContainsKey(legionName))
                {
                    legionSoldierTypeAndCounter[legionName] = new Dictionary<string, long>();
                    activityAndLegion[legionName] = lastActivity;
                }

                if(activityAndLegion[legionName] < lastActivity)
                {
                    activityAndLegion[legionName] = lastActivity;
                }

                if (!legionSoldierTypeAndCounter[legionName].ContainsKey(solderType))
                {
                    legionSoldierTypeAndCounter[legionName][solderType] = 0;
                }
                legionSoldierTypeAndCounter[legionName][solderType] += CountSolder;

            }

            var input = Console.ReadLine().Split('\\').ToList();

            if(input.Count < 2)
            {
                foreach (var kvp in activityAndLegion.OrderByDescending(x=>x.Value))
                {
                    if (legionSoldierTypeAndCounter[kvp.Key].ContainsKey(input[0]))
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
            else
            {
                int activity = int.Parse(input[0]);
                string soldier = input[1];

                foreach (var item in legionSoldierTypeAndCounter.Where( y => y.Value.ContainsKey(soldier))
                    .OrderByDescending(x=>x.Value[soldier]))

                {

                    if(activityAndLegion[item.Key] < activity)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[soldier]}");
                    }
                }
            }
        }
    }
}
