using System;


namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    count++;
                    if ( j + i == magical)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magical}");
                        return;
                    }  
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magical}");

        }
    }
}
