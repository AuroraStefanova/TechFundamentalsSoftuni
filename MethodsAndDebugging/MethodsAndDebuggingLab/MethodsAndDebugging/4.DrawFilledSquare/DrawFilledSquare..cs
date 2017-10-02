using System;

namespace _4.DrawFilledSquare
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            PrintHeader(n);

            for (int i = 0; i < n-2; i++)
            {
                PrintBody(n);
            }

            PrintHeader(n);

        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintBody(int n)
        {
            var body = "-";

            for (int i = 0; i < n-1; i++)
            {
                body += "\\/";
            }

            body += "-";
            Console.WriteLine(body);
        }
    }
}
