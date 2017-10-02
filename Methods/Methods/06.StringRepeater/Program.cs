using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringRepeater
{
    class Program
    {
        static void Main()
        {
            string someText = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string newText = RepeatStrings(someText,num);
            Console.WriteLine(newText);

        }
        static string RepeatStrings(string text,int times)
        {
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
