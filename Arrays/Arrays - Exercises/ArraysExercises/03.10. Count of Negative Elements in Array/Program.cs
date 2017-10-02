using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new int[n];
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < list.Length; i++)
            {
                int num = NegativeNumber(list[i]);
                count += num;
            }
            Console.WriteLine(count);
        }
        static int NegativeNumber(int number)
        {
            int count = 0;

            if(number < 0)
            {
                count++;
            }
            return count;
        }
    }
}
