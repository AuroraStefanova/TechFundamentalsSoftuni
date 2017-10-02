using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "Worm Ipsum")
            {
                int index = inputLine.IndexOf('.');

                if(index == -1 || !Char.IsUpper(inputLine[0]))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                //var inputArgs = inputLine.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
                int nextIndex = inputLine.IndexOf('.', index + 1);
                if(nextIndex != -1)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                inputLine = inputLine.TrimEnd('.');
                string[] words = inputLine.Split();
                char letter = '\0';

                for (int i = 0; i < words.Length; i++)
                {
                    string currentWord = words[i];
                    bool hasComma = false;
                    if(currentWord[currentWord.Length -1] == ',')
                    {
                        hasComma = true;
                    }
                    currentWord = currentWord.TrimEnd(',');
                    int maxCount = int.MinValue;
                    for (int j = 0; j < currentWord.Length - 1; j++)
                    {
                        int count = 0;

                        for (int k = j + 1; k < currentWord.Length; k++)
                        {
                            if(currentWord[j] == currentWord[k])
                            {
                                count++;
                            }
                        }
                        if(count !=0 && maxCount < count)
                        {
                            maxCount = count;
                            letter = currentWord[j];

                        }
                    }
                    if (maxCount != int.MinValue)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int m = 0; m < currentWord.Length; m++)
                        {
                            sb.Append(letter);
                        }

                        inputLine = inputLine.Replace(currentWord, sb.ToString());
                    }
                }


                Console.WriteLine("{0}.", inputLine);
                inputLine = Console.ReadLine();
            }

        }
    }
}
