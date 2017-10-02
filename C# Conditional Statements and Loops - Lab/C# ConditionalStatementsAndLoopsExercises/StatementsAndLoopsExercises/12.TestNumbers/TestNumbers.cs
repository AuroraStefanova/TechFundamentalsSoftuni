using System;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Max = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            bool flag = false;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    sum += 3 * i * j;
                    
                    count++;
                    if (sum >= Max)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {Max}");
                        flag = true;
                        return;
                    }
                    else if (sum < Max)
                    {
                        
                    }
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
            
        }
    }
}
