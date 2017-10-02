using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            var someText = Console.ReadLine()
                .Split(' ')
                .ToList();

            var words = new List<string>();
            var counts = new List<int>();

            for (int i = 0; i < someText.Count; i++)
            {
                if (!words.Contains(someText[i]))
                {
                    words.Add(someText[i]);
                    counts.Add(1);
                }
                else
                {
                    int index = words.IndexOf(someText[i]);
                    counts[index]++;
                }
            }
            for (int first = 0; first < counts.Count -1; first++)
            {
                var i = first + 1;
                while (i > 0)
                {
                    if( counts[i -1 ] < counts[i])
                    {
                        int tempCount = counts[i];
                        counts[i] = counts[i - 1];
                        counts[i - 1] = tempCount;

                        string tempWords = words[i];
                        words[i] = words[i - 1];
                        words[i - 1] = tempWords;
                    }
                    i--;
                }

            }
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i], counts[i], ((double)counts[i] / (double)someText.Count) * 100);

            }
        }
    }
}
