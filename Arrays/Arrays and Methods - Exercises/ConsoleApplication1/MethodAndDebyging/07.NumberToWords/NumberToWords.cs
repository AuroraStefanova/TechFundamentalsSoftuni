using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberToWordsTM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < -999) Console.WriteLine("too small");
                else if (number < -99) Console.WriteLine("minus " + Letterize(Math.Abs(number)));
                else if (number < 100) continue;
                else if (number < 1000) Console.WriteLine(Letterize(number));
                else Console.WriteLine("too large");
            }
        }
        public static string Letterize(int number)
        {
            string result = "";
            string[] str0To9 = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] str20To90 = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] str10to19 = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", };
            result = str0To9[number / 100] + "-hundred";
            number = number % 100;
            if (number == 0) ;
            else if (number < 10) result = result + " and " + str0To9[number];
            else if (number < 20) result = result + " and " + str10to19[number - 10];
            else
            {
                result = result + " and " + str20To90[(int)(number / 10)];
                number = number % 10;
                if (number != 0) result += " " + str0To9[number];
            }
            return result;
        }
    }
}
