using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rage = int.Parse(Console.ReadLine());

            var indexofAllBygs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var inputLine = Console.ReadLine();
            var fucking = new List<int>();

            for (int i = 0; i < rage; i++)
            {
                fucking.Add(0);
            }

            for (int i = 0; i < indexofAllBygs.Count; i++)
            {
                fucking[indexofAllBygs[i]] = 1;
            }

            Console.WriteLine(string.Join(" ", fucking));


            while (inputLine != "end")
            {
                var token = inputLine.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                int leidybugIndex = int.Parse(token[0]);
                string direction = token[1];
                int toIndex = int.Parse(token[2]);

                    if (fucking[leidybugIndex] != 1)
                    {
                        continue;
                    }
                    if (rage <= leidybugIndex + toIndex  || leidybugIndex < 0)
                    {
                        break;
                    }


                if (direction == "right")
                {
                   //if(leidybugIndex + toIndex >= rage)
                   //{
                   //    break;
                   //}
                    if (fucking[leidybugIndex + toIndex] == 1)
                    {
                        if (fucking[leidybugIndex + (toIndex + toIndex)] == 0)
                        {
                            if (fucking[leidybugIndex + (toIndex + toIndex)] > rage)
                            {
                                inputLine = Console.ReadLine();
                                continue;
                            }
                            else
                            {
                                fucking[leidybugIndex + (toIndex + toIndex)] = 1;

                            }
                        }
                    }
                    else if (fucking[leidybugIndex + toIndex] == 0)
                    {
                        if (fucking[leidybugIndex + (toIndex + toIndex)] > rage)
                        {
                            inputLine = Console.ReadLine();
                            fucking[leidybugIndex + (toIndex + toIndex)] = 0;
                            continue;
                        }
                        else
                        {
                            fucking[leidybugIndex + toIndex] = 1;

                        }


                    }


                    fucking[leidybugIndex] = 0;
                    Console.WriteLine(string.Join(" ", fucking));

                }
                else if (direction == "left")
                {
                    foreach (var bug1 in indexofAllBygs)
                    {
                        if (bug1 == toIndex)
                        {

                        }
                        else
                        {


                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", fucking));

        }
    }
}
