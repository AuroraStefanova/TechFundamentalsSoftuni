using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DictRef
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            var input = Console.ReadLine()
                .Split(new char[] {'=' ,' '},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (!input[0].Equals("end"))
            {
                for (int i = 0; i < input.Count; i++)
                {
                    string name = input[0];// pesho

                    int num;

                    bool isNumber = int.TryParse(input[1], out num);

                    if (isNumber)
                    {
                        if (!result.ContainsKey(name))
                        {
                            result.Add(name, 0);
                        }

                        result[name] = num;
                    }
                    else//(! isnum)
                    {
                        if (result.ContainsKey(input[1]))
                        {
                            if (!result.ContainsKey(name))
                            {
                                result.Add(name, 0);
                            }
                            result[name] = result[input[1]];
                        }
                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            foreach (var kvp in result)
            {
                string key = kvp.Key;
                int value = kvp.Value;
                Console.WriteLine($"{key} === {value}");
            }
        }
    }
}
