using System;
using System.Linq;


namespace _02.NegativeElementsInArray
{
    class NegativeElementsInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var number = new int[n];

            for (int i = 0; i < number.Length; i++)
            {
                number [i] = int.Parse(Console.ReadLine());
            }

            int count = 0; 

            for (int i = 0; i < number.Length; i++)
            {
                var currentNum = number[i];

                if(currentNum < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
