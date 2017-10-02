using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BinarySearch
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int numToFinde = int.Parse(Console.ReadLine());

            int countLinear = LinearSearch(numbers, numToFinde);
            int binaryCount = BinarySearch(numbers, numToFinde);


            if (numbers.Contains(numToFinde))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made { countLinear} iterations");
            Console.WriteLine($"Binary search made {binaryCount} iterations");
        }

        private static int LinearSearch(List<int> numbers, int numToFinde)
        {
            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                count++;
                if (numbers[i] == numToFinde)
                {
                    return count;
                }
            }
            return count;
        }
        static int BinarySearch(List<int> numbers, int numToFinde)
        {
            numbers.Sort();
            int min = 0;
            int max = numbers.Count-1;
            int count = 0;

            while (min <= max)
            {
                
                int midPoint = (min + max) / 2;
                count++;
                if (numbers[midPoint] < numToFinde)
                {
                    min = midPoint + 1;
                }

                if (numbers[midPoint] > numToFinde)
                {
                    max = midPoint - 1;
                }

                if(numbers[midPoint] == numToFinde)
                {
                    break;
                }
                //count++;
            }
            return count;
        }
    }
}
