using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> flattenDictionary = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] token = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (token[0] != "flatten")
                {


                    string item = token[0];
                    string innerKey = token[1];
                    string innerValue = token[2];

                    if (!flattenDictionary.ContainsKey(item))
                    {
                        flattenDictionary.Add(item, new Dictionary<string, string>());
                    }

                        flattenDictionary[item][innerKey] = innerValue;
                }

                else
                {
                    string key = token[1];
                    flattenDictionary[key] = flattenDictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");/// LOGICT TO FLATTEN
                }

                inputLine = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, string>> orderedDict = flattenDictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var result in orderedDict)
            {
                Console.WriteLine($"{result.Key}");

                Dictionary<string, string> outputDistionary = result
                    .Value
                    .Where(x => x.Value != "flatten")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenDict = result.Value
                    .Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                int count = 1;
                foreach (var inertEntry in outputDistionary)
                {
                    Console.WriteLine($"{count}. {inertEntry.Key} - {inertEntry.Value}");
                    count++;
                }
                foreach (var flattEntry in flattenDict)
                {
                    Console.WriteLine($"{count}. {flattEntry.Key}");
                    count++;
                }
            }

        }
    }
}
