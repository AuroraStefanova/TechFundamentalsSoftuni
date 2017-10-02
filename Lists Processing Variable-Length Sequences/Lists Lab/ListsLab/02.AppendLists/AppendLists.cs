using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main()
        {
            char[] arr = " "// delimet
                .ToCharArray();

            var num = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            var newList = new List<string>();

            for (int i = 0; i < num.Count; i++)
            {
                var thurtList = num[i].Split(arr, StringSplitOptions.RemoveEmptyEntries).ToList();
                //8 7 6 . . ...
                newList.AddRange(thurtList);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
