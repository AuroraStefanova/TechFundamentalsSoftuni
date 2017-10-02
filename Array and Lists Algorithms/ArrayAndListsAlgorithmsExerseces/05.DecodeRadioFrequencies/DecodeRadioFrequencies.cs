using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var representation = new List<char>();

            for (int i = 0; i < numbers.Length; i++)
            {
                string[] token = numbers[i].Split('.');//split by "." прави [i]тия елемент на две = разделя го 
                int firstFreq = int.Parse(token[0]);// тук се взима първия елемент от token 
                int secondFreq = int.Parse(token[1]);// тук се взима втория елемент от token 

                char firstLetter = (char)firstFreq;// вече елемента се превръща от номер в чар по utf8
                char secondLetter = (char)secondFreq;//взима се вече втория елемент в цифри и се превтръща в чар

                if(firstFreq != 0)
                {
                    representation.Insert(i, firstLetter);//добавя се чара на последна позиция 
                }

                if(secondFreq != 0)
                {
                    representation.Insert(representation.Count - 1 - i, secondLetter);// на първа позиция 
                }
            }
            representation.Reverse();
            Console.WriteLine(string.Join("", representation));
        }
    }
}
