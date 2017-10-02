using System;

namespace _08.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(MultiplyEvensOdds(num));
        }
        
        static int MultiplyEvensOdds(int numbers)
        {
            int Even = SumEven(numbers);
            int Odd = SumOdd(numbers);
            return Even * Odd;

        }

        static int SumOdd(int numbers)
        {
            int sumOdd = 0;

            while(numbers > 0)
            {
                int lastDig = numbers % 10;

                if (lastDig % 2 != 0)
                {
                    sumOdd+= lastDig;
                }
                numbers /= 10;

            }
            return sumOdd;
        }

        static int SumEven(int numbers)
        {
            int sumEven = 0;
            while (numbers > 0)
            {
                int lastDig = numbers % 10;

                if (lastDig % 2 == 0)
                {
                    sumEven+=lastDig;
                }
                numbers /= 10;

            }
            return sumEven;
        }
    }
}
