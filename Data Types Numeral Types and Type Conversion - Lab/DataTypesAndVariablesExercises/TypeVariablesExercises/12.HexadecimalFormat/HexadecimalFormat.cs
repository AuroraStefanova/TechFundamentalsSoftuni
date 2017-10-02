using System;

namespace _12.HexadecimalFormat
{
    class HexadecimalFormat
    {
        static void Main()
        {
            string num = Console.ReadLine();
            int decValue = Convert.ToInt32(num, 16);
            Console.WriteLine(decValue);
        }
    }
}
