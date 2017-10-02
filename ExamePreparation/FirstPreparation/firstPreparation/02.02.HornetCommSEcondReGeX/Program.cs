using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var broadcasts = new List<string>();
            var messages = new List<string>();
            Regex regex1 = new Regex("[0-9]+");
            Regex regex2 = new Regex("[^0-9]+");
            Regex regex3 = new Regex("[\\W]");
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Hornet is Green") { break; }
                string[] input = line.Split(new string[] { " <-> " }, StringSplitOptions.None);
                if (input.Count() != 2)
                {
                    continue;
                }
                string firstQuery = input[0];
                string secondQuery = input[1];
                if (regex1.IsMatch(firstQuery) && !regex3.IsMatch(secondQuery))
                {
                    string reversed = new string(firstQuery.ToCharArray().Reverse().ToArray());
                    string temp = reversed + " -> " + secondQuery;
                    messages.Add(temp);
                }
                if (regex2.IsMatch(firstQuery) && !regex3.IsMatch(secondQuery))
                {
                    StringBuilder secondQueryNew = new StringBuilder();
                    for (int i = 0; i < secondQuery.Length; i++)
                    {
                        if (secondQuery[i] <= 122 && secondQuery[i] >= 97)
                        {
                            secondQueryNew.Append(char.ToUpper(secondQuery[i]));
                        }
                        else if (secondQuery[i] >= 65 && secondQuery[i] <= 90)
                        {
                            secondQueryNew.Append(char.ToLower(secondQuery[i]));
                        }
                        else
                        {
                            secondQueryNew.Append(secondQuery[i]);
                        }
                    }
                    string temp = secondQueryNew + " -> " + firstQuery;
                    broadcasts.Add(temp);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            for (int i = 0; i < broadcasts.Count; i++)
            {
                Console.WriteLine(broadcasts[i]);
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            for (int i = 0; i < messages.Count; i++)
            {
                Console.WriteLine(messages[i]);
            }
        }
    }
}
