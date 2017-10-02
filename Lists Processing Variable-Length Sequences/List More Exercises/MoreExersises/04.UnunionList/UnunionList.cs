using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.UnunionList
{
    class UnunionList
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            //var numbers = new List<int> { 1, 2, 3, 4, 5 };

            int n = int.Parse(Console.ReadLine());

            var newDiferentList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                newDiferentList = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < newDiferentList.Count; j++)
                {
                    if (numbers.Contains(newDiferentList[j]))
                    {
                        //Console.WriteLine(numbers[i]);
                        numbers.RemoveAll(x => x == newDiferentList[j]);
                       
                        
                    }
                    else
                    {
                        numbers.Add(newDiferentList[j]);
                        //Console.WriteLine(string.Join(" ", numbers));
                    }
                }

            }
            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
