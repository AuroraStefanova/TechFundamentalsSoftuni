using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Hornet_Com
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> messageData = new List<string>();

            List<string> broadcastData = new List<string>();



            while (input != "Hornet is Green")
            {
                string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length != 2)
                {
                    input = Console.ReadLine();
                    continue;

                }
                string firstQuery = tokens[0];
                string secondQuery = tokens[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    string reversed = new string(firstQuery.Reverse().ToArray());
                    messageData.Add($"{reversed} -> {secondQuery}");

                    // Private
                }
                else if (firstQuery.All(s => !char.IsDigit(s) && secondQuery.All(char.IsLetterOrDigit)))
                {
                    // Broadcast
                    StringBuilder changedSecondQuery = new StringBuilder();
                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            changedSecondQuery.Append(symbol.ToString().ToLower());
                        }
                        else if (char.IsLower(symbol))
                        {
                            changedSecondQuery.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            changedSecondQuery.Append(symbol);
                        }
                    }
                    broadcastData.Add($"{changedSecondQuery} -> {firstQuery}");
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcastData.Any())
            {
                foreach (var broadcast in broadcastData)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messageData.Any())
            {
                foreach (var message in messageData)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}