using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] saperator = " .,:;()[]\"\\/!? ".ToCharArray();
            string[] text = Console.ReadLine().ToLower().Split(saperator, StringSplitOptions.RemoveEmptyEntries).Where(n => n.Length < 5).Distinct().OrderBy(x=> x).ToArray();

            Console.WriteLine(string.Join(", ", text));

        }
    }
}
