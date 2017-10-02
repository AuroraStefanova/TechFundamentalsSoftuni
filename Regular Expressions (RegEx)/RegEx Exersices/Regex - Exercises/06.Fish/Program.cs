using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">*<*\(+['\-x]>";

            var inputLine = Console.ReadLine();
            var maches = Regex.Matches(inputLine, pattern);

            int count = 0;

            foreach (Match item in maches)
            {
                var tail = 0;
                var body = 0;
                count++;

                var tipeOfTail = "";
                var bodyType = "";
                var status = "";
                Console.WriteLine("Fish {1}: {0}", item, count);

                foreach (char @char in item.ToString())
                {
                    if (@char == '>')
                    {
                        tail++;
                    }
                    else if (@char == '(')
                    {
                        body++;
                    }
                    else if (@char == '\'')
                    {
                        status = "Awake";
                    }
                    else if (@char == '-')
                    {
                        status = "Asleep";
                    }
                    else if (@char == 'x')
                    {
                        status = "Dead";
                    }
                }

                tail--;

                if (tail > 5)
                {
                    tipeOfTail = "Long";
                }
                else if (tail > 1)
                {
                    tipeOfTail = "Medium";
                }
                else if (tail == 1)
                {
                    tipeOfTail = "Short";
                }
                else
                {
                    tipeOfTail = "None";
                }

                if(body > 10)
                {
                    bodyType = "Long";
                }
                else if (body > 5)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }

                Console.Write("  Tail type: {0}", tipeOfTail);
                if (tail > 0)
                {
                    Console.WriteLine(" ({0} cm)", tail * 2);
                }
                else
                {
                    Console.WriteLine();
                }
                Console.WriteLine("  Body type: {1} ({0} cm)", body * 2, bodyType);
                Console.WriteLine("  Status: {0}", status);

            }
            if (count == 0)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
