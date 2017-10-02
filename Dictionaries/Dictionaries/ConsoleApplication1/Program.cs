using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary < string, int > word = new Dictionary<string, int>();
            string[] wordsInput = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < wordsInput.Length; i++)
            {
                if (!word.ContainsKey(wordsInput[i], 0))
                {

                }
            }
        }
    }
}
