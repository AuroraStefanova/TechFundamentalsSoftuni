using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.HappinessIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var smile = @"(:\))|(:D)|(;\))|(:\*)|(:])|(;])|(:})|(;})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)";
            var sad = @"(:\()|(D:)|(;\()|(:\[)|(;\[)|(:{)|(;{)|(\):)|(:c)|(]:)|(];)";

            var input = Console.ReadLine();

            var matcSmile = Regex.Matches(input, smile);
            var machSad = Regex.Matches(input, sad);
            double smileCount = 0;
            double countSad = 0;

            foreach (Match item in machSad)
            {
                countSad++;
            }
            foreach (Match item in matcSmile)
            {
                smileCount++;
            }

            var index = (double)smileCount / countSad;

            string emoticon = "";

            if(index >= 2)
            {
                emoticon = ":D";
            }
            else if(index > 1 && index < 2)
            {
                emoticon = ":)";
            }
            else if(index == 1)
            {
                emoticon = ":|";
            }
            else if(index < 1)
            {
                emoticon = ":(";
            }

            Console.WriteLine($"Happiness index: {index:F2} {emoticon}");
            Console.WriteLine($"[Happy count: {smileCount}, Sad count: {countSad}]");
        }
    }
}
