using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main()
        {

            var element = Console.ReadLine()
                .Split(' ')
                .ToList();

            double totalSum = 0;
            double countChar = 0;
            for (int i = 0; i < element.Count; i++)
            {
                string word = element[i];
                countChar += word.Length;
                for (int j = 0; j < word.Length; j++)
                {
                    totalSum += word[j];
                }
            }
            char chardelimitar = (char)((int)(totalSum / countChar));
            string delimitar = chardelimitar.ToString().ToUpper();
            Console.WriteLine(string.Join(delimitar, element));
        }
    }
}
