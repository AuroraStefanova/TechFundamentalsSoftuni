using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int COUNT = 0;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var pokemonCount = new List<int>();

            while (input.Count != 0)
            {
                var remuver = int.Parse(Console.ReadLine());

                if (remuver >= 0)
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        COUNT ++;
                        int index = input[remuver];

                        input.RemoveAt(remuver);
                        pokemonCount.Add(index);

                        if( input[i] <= index)
                        {
                            input[i] += index;
                        }

                        else if (input[i] > index)
                        {
                            input[i] -= index;
                        }

                        Console.WriteLine($" {COUNT}  -> {string.Join(" ", input)}");
                    }
                }

            }
        }
    }
}
