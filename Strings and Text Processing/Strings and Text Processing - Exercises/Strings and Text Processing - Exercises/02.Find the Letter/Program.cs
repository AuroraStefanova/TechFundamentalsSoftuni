using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var occurence = Console.ReadLine().Split(' ').ToList();

            string letter = occurence[0];
            int numberOfLetter = int.Parse(occurence[1]);
            int index = inputLine.IndexOf(letter);
           // bool isFound = false;
            int count = 0;
            while (index != -1)
            {
                count++;      

                if(count == numberOfLetter)
                {
                    Console.WriteLine(index);
                    //isFound = true;
                    return;

                }
                index = inputLine.IndexOf(letter, index + 1);

            }
            Console.WriteLine("Find the letter yourself!");
        }
    }
}
