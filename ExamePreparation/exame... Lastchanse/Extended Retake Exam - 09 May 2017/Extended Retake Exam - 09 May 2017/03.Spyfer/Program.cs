using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputLine.Count ; i++)
            {
                //int firstIndex = inputLine[i-1];
                int currentIndex = inputLine[i];
                

                if(i != 0 && i != inputLine.Count - 1)
                {
                    int sumIndex = inputLine[i - 1] + inputLine[i + 1];

                    if (currentIndex == sumIndex)
                    {
                        inputLine.RemoveAt(i + 1);
                        inputLine.RemoveAt(i - 1);

                        i = 0;
                    }                                   
                }
                else if (i == 0 && currentIndex == inputLine[i + 1])
                {
                    inputLine.RemoveAt(i + 1);
                    i = 0;

                }
                else if (i == inputLine.Count - 1 && currentIndex == inputLine[i - 1])
                {
                    inputLine.RemoveAt(i - 1);
                    i = 0;

                }
            }

            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
