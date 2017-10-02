using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string, HashSet<string>>> result = new Dictionary<int, Dictionary<string, HashSet<string>>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "Time for Code")
            {
                var token = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                int ID = int.Parse(token[0]);
                string eventName = token[1];

                if (eventName.Contains("#"))
                {

                    if (!result.ContainsKey(ID))
                    {
                        result[ID] = new Dictionary<string, HashSet<string>>();

                    }

                    if (!result[ID].ContainsKey(eventName))
                    {
                        result[ID].Add(eventName, new HashSet<string>());
                    }
                    string[] people = token.Skip(2).ToArray();


                    foreach (var item in people)
                    {

                        if (item.Contains("@"))
                        {

                            result[ID][eventName].Add(item);

                        }
                    }

                }


                else
                {
                    continue;
                }

                inputLine = Console.ReadLine();
            }
            
            foreach (var kvp in result.OrderByDescending(x => x.Value.Values.Count))
            {


                //Console.WriteLine($"{kvp.}");
                int count = 0;
                foreach (var item in kvp.Value)
                {

                    foreach (var ssdd in item.Value)
                    {
                        count++;
                    }
                    string newName = "";
                    for (int i = 1; i < item.Key.Length- 1; i++)
                    {
                        newName += item.Key[i];
                    }
                    Console.WriteLine($"{newName} - {count}");
                    Console.WriteLine($"{string.Join("\n\r", item.Value)}");
                }


            }

        }
    }
}
