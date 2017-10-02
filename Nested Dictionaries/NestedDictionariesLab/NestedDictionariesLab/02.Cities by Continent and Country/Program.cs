using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsDate = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string contri = input[1];
                string city = input[2];

                if (!continentsDate.ContainsKey(continent))
                {
                    continentsDate[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsDate[continent].ContainsKey(contri))
                {
                    continentsDate[continent][contri] = new List<string>();
                }
                continentsDate[continent][contri].Add(city);
            }
            foreach (var continentInDictiomary in continentsDate)
            {
                
                Console.WriteLine($"{continentInDictiomary.Key}:");

                foreach (var kvp in continentInDictiomary.Value)
                {
                    Console.WriteLine($"  {kvp.Key} -> {string.Join(", ", kvp.Value)}");

                }
            }
        }
    }
}
