using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._11.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNum = (Console.ReadLine()).Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());
            int piece = 0;
            int count = 0;
            int num = 0;
            for (int i = 0; i < listNum.Count; i++)
            {
                piece = listNum[i];
                num = CountNumber(piece, number);

                count += num;
            }
            Console.WriteLine(count);
        }
        static int CountNumber(int pieces, int numbers)
        {
            int count = 0;

            if(pieces == numbers)
            {
                count++;
            }

            return count;
        }
    }
}
