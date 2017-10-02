using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                string[] tokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                if (input != "dance")
                {
                    string[] objProp = tokens[1].Split('.');
                    string selector = tokens[0];
                    string selectorObject = objProp[0];
                    string property = objProp[1];

                    if (!data.ContainsKey(selector))
                    {
                        data[selector] = new Dictionary<string, string>();
                    }

                    if (!data[selector].ContainsKey(selectorObject))
                    {
                        data[selector][selectorObject] = "";
                    }
                    data[selector][selectorObject] = property;
                }

                else if (input == "dance")
                {
                    data = data
                       .ToDictionary(sel => sel.Key, sel => sel.Value.ToDictionary(
                          selObject => selObject.Key,
                          selObject => selObject.Key + "." + selObject.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var selectData in data)
            {
                string obj = selectData.Key;
                Dictionary<string, string> pair = selectData.Value;

                Console.Write($"{obj} => ");

                foreach (var pairData in pair)
                {
                    string objselector = pairData.Key;
                    string objProp = pairData.Value;
                    Console.WriteLine($"{objselector}.{objProp}");
                }
            }
        }
    }
}
