using System;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintingTriangleN(n);
        }

        static void PrintingTriangleN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }

            for (int i = n -1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
