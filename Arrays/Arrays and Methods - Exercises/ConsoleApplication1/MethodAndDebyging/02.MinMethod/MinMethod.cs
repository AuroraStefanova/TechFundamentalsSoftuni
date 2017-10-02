using System;
using System.Linq;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());//8
            int second = int.Parse(Console.ReadLine());//7
            int thurd = int.Parse(Console.ReadLine());//6

            MinOfThree(first, second, thurd);

        }
        static int MinOfThree(int number, int secondNum, int ThurtNum)
        {
            int biger = int.MaxValue;

            if(number < biger)// 8 = a
            {
                biger = number;

                if( secondNum < biger)
                {
                    biger = secondNum;

                    if( ThurtNum < biger)
                    {
                        biger = ThurtNum;
                    }
                }
                if( ThurtNum < biger)
                {
                    biger = ThurtNum;

                    if( secondNum < biger)
                    {
                        biger = secondNum;
                    }
                }
            }
            else if(secondNum < biger)
            {
                biger = secondNum;

                if( number < biger)
                {
                    biger = secondNum;

                    if( ThurtNum < biger)
                    {
                        biger = ThurtNum;
                    }
                }
                if(ThurtNum < biger)
                {
                    biger = ThurtNum;
                    {
                        if( secondNum < biger)
                        {
                            biger = secondNum;
                        }
                    }
                }

            }
            else if(ThurtNum < biger)
            {
                biger = ThurtNum;

                if( secondNum < biger)
                {
                    biger = secondNum;

                    if( number <  biger)
                    {
                        biger = number;
                    }
                }
                if(number < biger)
                {
                    biger = number;
                    if( secondNum < biger)
                    {
                        biger = secondNum;
                    }
                }
            }
            Console.WriteLine(biger);
            return biger;
        }
    }
}
