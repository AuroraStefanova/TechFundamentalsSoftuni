using System;



namespace _06.IncrementVariable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int num = 0;

            if(n < 256)
            {
                num = n;
                Console.WriteLine($"{num}");
            }
            if(n >= 256)
            {
                count = n / 256;
                num = (n % 256);
                Console.WriteLine(num);
                Console.WriteLine($"Overflowed {count} times");
            }
        }
    }
}
