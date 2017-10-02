using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^0-9]+)([0-9]+)";

            var inputLine = Console.ReadLine();

            var matches = Regex.Matches(inputLine, pattern);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                //Console.WriteLine(match.Groups[1]);
                var count = int.Parse(match.Groups[2].Value);
                string text = (match.Groups[1].ToString()).ToUpper();

                for (int i = 0; i < count; i++)
                {
                    result.Append(text);
                }
                
            }
            int cnt = (result.ToString().Distinct().Count());
            Console.WriteLine($"Unique symbols used: {cnt}");
            Console.WriteLine(result);
            
        }
    }
}
