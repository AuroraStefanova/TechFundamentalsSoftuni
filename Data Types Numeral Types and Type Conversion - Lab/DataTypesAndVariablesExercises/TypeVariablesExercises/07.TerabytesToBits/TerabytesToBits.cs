using System;
using System.Numerics;

namespace _07.TerabytesToBits
{
    class TerabytesToBits
    {
        static void Main()
        {
            decimal num = decimal.Parse(Console.ReadLine());
            // C# compiler is stupid... it adds zeros at the end, and that's why the stupid thing overflowed...
            decimal terabytes = 8796093022208 * num;

            Console.WriteLine($"{terabytes:F0}");
        }
    }
}
