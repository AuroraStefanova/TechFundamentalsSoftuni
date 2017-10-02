using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0444.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = new List<int>();
            var thirdList = new List<int>();
            var result = new List<int>();


            if (input.Count % 2 != 0)
            {
                for (int i = input.Count / 2 + 1; i < input.Count - 1; i++)
                {
                    secondList.Add(input[i]);
                }

                secondList.Reverse();
                secondList.Insert(0, input[0]);// 1 10 9 8 7 

                for (int i = 1; i < input.Count / 2; i++)
                {
                    thirdList.Add(input[i]);
                }
                thirdList.Reverse();//5 4 3 2 
                thirdList.Add(input.Count);// 


                result.AddRange(secondList);

                result.Add(input.Count / 2 + 1);

                result.AddRange(thirdList);

                Console.WriteLine(string.Join(" ", result));
            }
            else if(input.Count % 2 == 0)
            {
                for (int i = input.Count/2; i < input.Count-1; i++)
                {
                    secondList.Add(input[i]);
                }

                secondList.Reverse();
                secondList.Insert(0, input[0]); // 2 4

                for (int i = 1; i < input.Count/2; i++)
                {
                    thirdList.Add(input[i]);
                }

                thirdList.Reverse();

                thirdList.Add(input[input.Count - 1]);

                result.AddRange(secondList);
                result.AddRange(thirdList);

                Console.WriteLine(string.Join(" ", result));

            }

        }
    }
}
