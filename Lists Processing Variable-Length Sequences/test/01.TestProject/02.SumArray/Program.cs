using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var number = new List<int>();

           // Array []   arr [0, 0, 0, 0]
           //arr[2]= 1 arr[0,0, 1,0


            for (int i = 0; i < num; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                number.Add(currentNum);
            }
            int sum = 0;

            for (int i = 0; i < number.Count; i++)
            {
                var secondNum = number[i];
                sum += secondNum;
            }

            Console.WriteLine(sum);
        }
    }
}
