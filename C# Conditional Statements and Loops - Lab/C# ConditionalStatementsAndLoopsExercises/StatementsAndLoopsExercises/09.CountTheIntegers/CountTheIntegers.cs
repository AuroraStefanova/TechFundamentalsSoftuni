using System;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            string num = Console.ReadLine();
            int caun = 0;
            while (true)
            {
                int number = 0;
                bool isNum = int.TryParse(num, out number);

               
                if (isNum)
                {
                    caun++;
                }
                else
                {
                    Console.WriteLine(caun);
                    return;
                }

                num = Console.ReadLine();
            }
           
        }
    }
}
