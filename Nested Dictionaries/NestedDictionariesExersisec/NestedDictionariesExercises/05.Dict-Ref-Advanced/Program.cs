using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = new Dictionary<string, List<int>>();
            int n;
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end") { break; }
                string[] values = input[1]
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                if (!entries.ContainsKey(name))
                {
                    if (!int.TryParse(values[0], out n) && !entries.ContainsKey(values[0]))
                    {
                        continue;
                    }
                    entries.Add(name, new List<int>());
                }
                for (int i = 0; i < values.Length; i++)
                {
                    if (int.TryParse(values[i], out n))
                    {
                        entries[name].Add(n);
                    }
                    else
                    {
                        if (entries.ContainsKey(values[i]))
                        {
                            entries[name] = new List<int>();
                            for (int j = 0; j < entries[values[i]].Count; j++)
                            {
                                entries[name].Add(entries[values[i]][j]);
                            }
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, List<int>> item in entries)
            {
                Console.Write($"{item.Key} === ");
                Console.Write(string.Join(", ", item.Value));
                Console.WriteLine();
            }
        }
    }
}