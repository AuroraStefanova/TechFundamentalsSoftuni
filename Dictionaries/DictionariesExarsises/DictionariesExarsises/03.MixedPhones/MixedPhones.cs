using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main()
        {
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            var input = Console.ReadLine()
                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "Over")
            {

                long phoneNumber;
                if(long.TryParse(input[0], out phoneNumber))
                {
                    phonebook[input[1]] = phoneNumber;

                }
                else if(long.TryParse(input[1], out phoneNumber))
                {
                    phonebook[input[0]] = phoneNumber;
                }


                input = Console.ReadLine()
                  .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToList();
            }
            foreach (var kor in phonebook)
            {
                string key = kor.Key;
                long value = kor.Value;
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
