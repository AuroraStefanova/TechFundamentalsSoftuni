using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string pat = @"(^|(?<=[SHDC]))(10|[2-9|J|Q|K|A])[S|H|D|C]";

            var input = Console.ReadLine();

            Regex regex = new Regex(pat);

            MatchCollection result = regex.Matches(input);

            var machedCards = result.Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", machedCards));
        }
    }
}
