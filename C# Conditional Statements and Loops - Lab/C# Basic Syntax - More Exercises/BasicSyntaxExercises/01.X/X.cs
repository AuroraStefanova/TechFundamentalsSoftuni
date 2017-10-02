using System;

namespace _01.X
{
    class X
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int space = 0;
            int space2 = n - 2;

            //top row
            for (int row = 0; row < (n / 2) ; row++)
            {
                Console.WriteLine(new string(' ', space) + 'x' + new string(' ', space2) + 'x');

                space++;
                space2 -= 2;

            }
            //middle row
            space = (n - 1) / 2;
            space2 = -1;

            // bottom row
            for (int i = 0; i < ((n + 1) / 2); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(new string(' ', space) + 'x');
                }
                else
                {
                    Console.WriteLine(new string(' ', space) + 'x' + new string(' ', space2) + 'x');
                }
                space--;
                space2 += 2;
            }
        }
    }
}

