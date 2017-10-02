using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp135
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                   StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            while (true)
            {
                var lessGrapesList = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (i == numbers.Count - 1)
                        {
                            break;
                        }

                        if (i > 0)
                        {

                            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                            {
                                lessGrapesList.Add(i - 1);
                                lessGrapesList.Add(i + 1);
                                lessGrapesList.Add(i);
                                numbers[i]++;

                                if (numbers[i - 1] > 0)
                                {
                                    numbers[i]++;
                                    numbers[i - 1] = Math.Max(numbers[i - 1] - 1, 0);
                                }

                                if (numbers[i + 1] > 0)
                                {
                                    numbers[i]++;
                                    numbers[i + 1] = Math.Max(numbers[i + 1] - 1, 0);
                                }
                            }
                        }
                    }

                    lessGrapesList = lessGrapesList.Distinct().ToList();

                    for (int i = 0; i < numbers.Count; i++)
                    {

                        var notLessBr = 0;

                        for (int k = 0; k < lessGrapesList.Count; k++)
                        {
                            if (i != lessGrapesList[k])
                            {
                                notLessBr++;
                            }

                        }

                        if (notLessBr == lessGrapesList.Count)
                        {
                            if (numbers[i] > 0)
                            {
                                numbers[i]++;
                            }
                        }
                    }
                }
                var find = numbers.FindAll(x => x > n).ToList();

                if (find.Count < n)
                {
                    numbers.RemoveAll(x => x <= n);
                    break;
                }

                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= n)
                        {
                            numbers[i] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}