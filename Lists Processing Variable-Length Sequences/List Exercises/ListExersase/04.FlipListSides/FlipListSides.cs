using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            var inputNum = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();// 1       6       11

            var newList = new List<int>();

            for (int i = 1; i < inputNum.Count/ 2; i++)
            {
                newList.Add(inputNum[i]);// dobavq se pyrvata chast v nov list
            }

            newList.Reverse();//nowiq list se obryshta  5 4 3 2 

            var newSecondList = new List<int>();

            for (int i = inputNum.Count/ 2 + 1 ; i < inputNum.Count-1 ; i++)
            {
                newSecondList.Add(inputNum[i]);//v treti list se dobavq vtorata chast 7 8 9 10
            }

            newSecondList.Reverse();// rivyrsva se 

            Console.Write(string.Join(" ", inputNum[0]+ " "));
            newSecondList.AddRange(newList);
            newSecondList.Add(6);
            Console.Write(string.Join(" ",newSecondList));
            Console.Write(" ");
            Console.Write(string.Join(" ", inputNum[inputNum.Count - 1]));

            Console.WriteLine();
        }
    }
}
