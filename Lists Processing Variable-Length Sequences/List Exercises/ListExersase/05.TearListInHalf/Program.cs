using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TearListInHalf
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var newList = new List<int>();

            for (int i = input.Count / 2; i < input.Count; i++)
            {
                //Console.Write(input[i] + " ");//45  14 22    45/10 == 4   45 % 10 == 5
                newList.Add(input[i]);
            }
            //Console.WriteLine();
            var secondList = new List<int>();
            for (int i = 0; i < input.Count/2; i++)
            {
                //Console.Write( input[i]+ " ");
                secondList.Add(input[i]);// 11 22 33 
            }
            //Console.WriteLine();
            // 4 11 5 1 22 4 2 33 2
            var result = new List<string>();

            for (int i = 0; i < newList.Count ; i++)
            {
                //newList     [4, 5, 1, 4, 1, 2]
                //secondList  [11, 22, 33]
                result.Add((newList[i] / 10).ToString());
                result.Add(secondList[i].ToString());//11
                //
                result.Add((newList[i]%10).ToString());

            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
