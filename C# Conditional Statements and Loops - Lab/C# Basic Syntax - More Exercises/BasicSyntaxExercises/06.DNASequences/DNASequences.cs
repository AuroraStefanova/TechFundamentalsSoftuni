using System;

namespace _06.DNASequences
{
    class DNASequences
    {
        private static int l;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 4; i++)
            {
                for (var j = 1; j <= 4; j++)
                {
                    for (var k = 1; k <= 4; k++)
                    {
                        var preSufix = n > i + j + k ? "X" : "O";
                        var firstChar = i == 1 ? "A" : i == 2 ? "C" : i == 3 ? "G" : "T";
                        var secondChar = j == 1 ? "A" : j == 2 ? "C" : j == 3 ? "G" : "T";
                        var thirdChar = k == 1 ? "A" : k == 2 ? "C" : k == 3 ? "G" : "T";

                        if( k > 1)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(preSufix + firstChar + secondChar + thirdChar + preSufix);

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
