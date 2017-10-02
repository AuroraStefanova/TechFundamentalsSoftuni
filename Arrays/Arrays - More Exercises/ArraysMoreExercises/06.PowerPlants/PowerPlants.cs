using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.PowerPlants
{
    class PowerPlants
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //int decreases = 0;
            int days = -1;
            //season == number of plants 
            //int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if(numbers[i] > 0)// plants dies 
                {
                    numbers[i]++;
                }

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] > 0)
                    {
                        numbers[j]--;
                    }
                }
                days += 1;

                int sum = 0;
                for (int k = 0; k < numbers.Length; k++)
                {
                    sum += numbers[k];
                }

                if (sum > 0)
                {
                    if (i == numbers.Length - 1)
                    {
                        for (int m = 0; m < numbers.Length; m++)
                        {
                            if (numbers[m] > 0)// prelom na sezona 
                            {
                                numbers[m]++;
                            }
                        }
                        i = -1;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine($"survived {days + 1} days ({days / numbers.Length} seasons)");
                    break;
                }
            }
           
        }
    }
}
