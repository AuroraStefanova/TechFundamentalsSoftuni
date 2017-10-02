using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._12.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNumber = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double p = double.Parse(Console.ReadLine());
            double count = 0;
            for (int i = 0; i < listNumber.Count; i++)
            {
                double num = listNumber[i];
                double currentNumber = LargeNumber(p, num);
                count += currentNumber;
            }
            Console.WriteLine(count);
        }
        static double LargeNumber( double Ps,double numbers)
        {
            int count = 0;
            if(numbers > Ps)
            {
                count++;
            }

            return count;
        }
    }
}
