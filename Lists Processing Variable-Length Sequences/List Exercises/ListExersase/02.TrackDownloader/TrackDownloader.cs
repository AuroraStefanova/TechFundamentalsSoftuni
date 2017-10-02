using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blacklistWords = Console.ReadLine()
                .Split(' ')
                .ToList();

            var textList = new List<string>();
            var song = Console.ReadLine();
          

            while (song != "end")
            {
                CheckWords(textList, blacklistWords, song.ToString());
                song = Console.ReadLine();

            }
            textList.Sort();
            Console.WriteLine(string.Join("\r\n", textList));
        }

        static void CheckWords(List<string> textList, List<string> blacklistWords, string song)
        {
            bool isContained = false;
            for (int i = 0; i < blacklistWords.Count; i++)
            {
                if (song.Contains(blacklistWords[i]))
                {
                    isContained = true;
                }
            }
           
            if (!isContained)
            {
                textList.Add(song);
            }
        }
    }
}
