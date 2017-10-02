using System;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            string simbol = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                string words = Console.ReadLine();
                result += words + simbol;
            }
            string removeLastChar = result.Remove(result.Length - simbol.Length, simbol.Length);
            Console.WriteLine($"{removeLastChar}");
        }
    }
}
