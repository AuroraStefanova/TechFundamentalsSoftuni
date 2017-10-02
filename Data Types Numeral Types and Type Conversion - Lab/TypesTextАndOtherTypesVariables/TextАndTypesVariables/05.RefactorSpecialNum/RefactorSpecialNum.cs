using System;


namespace _05.RefactorSpecialNum
{
    class RefactorSpecialNum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 01; i <= num; i++)
            {

                int allSum = 0;
                int digits = i;

                while (digits > 0)
                {
                    allSum += digits % 10;
                    digits = digits / 10;
                }
                bool special = ((allSum == 5) || (allSum == 7) || (allSum == 11));
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
