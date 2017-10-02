using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OptimizedBankingSystem
{
    class BankAccaunt
    {
        public string Banck { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<BankAccaunt> result = new List<BankAccaunt>();

            while (input != "end")
            {
                string[] token = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string bank = token[0];
                string accauntName = token[1];
                decimal balance = decimal.Parse(token[2]);


                BankAccaunt newBankAcaunt = new BankAccaunt();
                newBankAcaunt.Name = accauntName;
                newBankAcaunt.Banck = bank;
                newBankAcaunt.Balance = balance;
                result.Add(newBankAcaunt);

                input = Console.ReadLine();
            }

            foreach (var item in result.OrderByDescending(x => x.Balance).ThenBy(x => x.Banck.Length))
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Banck})");
            }
        }
    }
    
}
