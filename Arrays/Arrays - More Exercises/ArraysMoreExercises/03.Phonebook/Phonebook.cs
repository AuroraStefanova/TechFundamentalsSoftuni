using System;
using System.Linq;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine()
                .Split()
                //.Select(int.Parse)
                .ToArray();

            var names = Console.ReadLine()
                .Split()
                .ToArray();
            string inputDone = Console.ReadLine();

            while(inputDone != "done")
            {
                PrintElement(names, phoneNumbers, inputDone);
                inputDone = Console.ReadLine();
            }

        }
        static void PrintElement(string[] name, string[] phone, string input)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i] == input)
                {
                    Console.WriteLine($"{name[i]} -> {phone[i]}");
                }
            }
        }
    }
}
