using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bankingSistem = new Dictionary<string, Dictionary<string, decimal>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] token = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string nameOfBanks = token[0];
                string personsName = token[1];
                decimal balance = decimal.Parse(token[2]);

                if (!bankingSistem.ContainsKey(nameOfBanks))
                {
                    bankingSistem.Add(nameOfBanks, new Dictionary<string, decimal>());
                }

                if (!bankingSistem[nameOfBanks].ContainsKey(personsName))
                {
                    bankingSistem[nameOfBanks][personsName] = 0;
                }
                bankingSistem[nameOfBanks][personsName] += balance;

                inputLine = Console.ReadLine();
            }

            foreach (var item in bankingSistem.OrderByDescending(x => x.Value.Sum(balD => balD.Value))
                                .ThenByDescending(data => data
                                .Value.Max(balance => balance.Value)))
            {
                var bankName = item.Key;
                var name = item.Value;

                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value} ({bankName})");
                }
            }
        }
    }
}
