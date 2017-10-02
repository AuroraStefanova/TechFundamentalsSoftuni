using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var token = inputLine.Split(' ');
                string command = token[0];

                if (command == "reverse")
                {
                    int start = int.Parse(token[2]);
                    int count = int.Parse(token[4]);

                    if (start < 0 || start >= numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters");

                    }
                    long CountPlusStart = start + count;
                    if (count < 0 || CountPlusStart >= numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters");

                    }

                    var newElements = numbers.Skip(start).Take(count).Reverse().ToList();
                    numbers.RemoveRange(start, count);
                    numbers.InsertRange(start, newElements);
                }
                else if (command == "Sort")
                {
                    int start = int.Parse(token[2]);
                    int count = int.Parse(token[4]);

                    if (start < 0 || start >= numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters");

                    }
                    long CountPlusStart = start + count;
                    if (count < 0 || CountPlusStart >= numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters");

                    }
                    var elements = numbers.Skip(start).Take(count).ToList();
                    elements.Sort();
                    numbers.RemoveRange(start, count);
                    numbers.InsertRange(start, elements);
                }
                else if (command == "rollLeft")
                {
                    int count = int.Parse(token[1]);
                    if (count < 0 || count > numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters");

                    }

                    for (int i = 0; i < count % numbers.Count; i++)
                    {
                        var firstElement = numbers[0];
                        for (int k = 0; k < numbers.Count; k++)
                        {
                            numbers[k] = numbers[k + 1];
                        }
                        numbers[numbers.Count - 1] = firstElement;
                    }

                }
                else if (command == "rollRight")
                {
                    int count = int.Parse(token[1]);
                    if (count < 0 || count > numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters");
                    }

                    for (int i = 0; i < count % numbers.Count; i++)
                    {
                        var lastElement = numbers[numbers.Count - 1];
                        for (int k = numbers.Count; k > 0; k--)
                        {
                            numbers[k] = numbers[k - 1];
                        }
                        numbers[0] = lastElement;
                    }
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
