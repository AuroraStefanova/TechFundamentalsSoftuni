using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ShootListElement
{
    class ShootListElement
    {
        static void Main()
        {
            var numbers = new List<int>();

            string input = Console.ReadLine();
            double avarage = 0;
            double small = 0;
            var smallerThanAverage = new List<int>();

            while (input !="stop")
            {
                if(input == "bang")         
                {
                    //TODO - remove first element  smaller than the average of elements
                    if (numbers.Count > 0)
                    {
                        avarage = numbers.Average();// AVERAGE value of the list

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if( numbers[i] <= avarage)
                            {
                                small = numbers[i];
                                Console.WriteLine("shot {0}", string.Join(" ", numbers[i]));
                                numbers.RemoveAt(i);
                                //numbers.Select(x => x  - 1);
                                for (int j = 0; j < numbers.Count; j++)
                                {
                                    numbers[j]--;
                                }
                                break;
                            }
                        }

                    }
                    else if(numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {small}");
                        return;
                    }
                }
                else
                {
                    // TODO  place input at the front of the list
                    numbers.Insert(0, int.Parse(input));
                    //
                   // Console.WriteLine("shot {0}", string.Join(" ", numbers));

                }

                
                input = Console.ReadLine();
            }
            if(numbers.Count > 0)
            {
               //double sum = 0;
               //foreach (var num in numbers)
               //{
               //    sum += num;
               //}
                Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {small}");
            }
        }
    }
}
