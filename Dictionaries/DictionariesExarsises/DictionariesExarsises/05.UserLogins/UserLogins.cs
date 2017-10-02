using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.UserLogins
{
    class UserLogins
    {
        static void Main()
        {
            Dictionary<string, string> userLoogin = new Dictionary<string, string>();

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int count = 0;

            while (input[0] != "login")
            {
                string name = input[0];
                string pass = input[2];

                if (!userLoogin.ContainsKey(name))
                {
                    userLoogin.Add(name, pass);
                }
                if(userLoogin.ContainsKey(name))
                {
                    userLoogin[name] = pass;
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (input[0] != "end")
            {
                string name = input[0];
                string pass = input[2];

                if (!userLoogin.ContainsValue(pass))
                {
                    count++;
                    Console.WriteLine($"{name}: login failed");
                    
                }
                if (!userLoogin.ContainsKey(name))
                {
                    count++;
                    Console.WriteLine($"{name}: login failed");
                    

                }
                if(userLoogin.ContainsKey(name) && userLoogin.ContainsValue(pass))
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
