using System;


namespace _01.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfAll = 0;
                int digits = i;

                while (digits > 0)
                {
                    sumOfAll += digits % 10;
                    digits = digits / 10;
                }

                bool special = ((sumOfAll == 5) || (sumOfAll == 7) || (sumOfAll == 11));
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
