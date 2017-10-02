using System;
using System.Collections.Generic;
using System.Linq;


namespace _022.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
             var numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
            
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string insertionNumbers = Console.ReadLine();

            while (insertionNumbers != "end")
            {
                string firstDigit = insertionNumbers[0].ToString();//25 == 2 
                numbers.Insert(int.Parse(firstDigit), int.Parse(insertionNumbers));
                //Console.WriteLine(string.Join(" ", numbers));

                insertionNumbers = Console.ReadLine();
                    
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
